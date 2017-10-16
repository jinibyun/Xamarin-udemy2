﻿using HelloWorld.Models;
using HelloWorld.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListExcercisePage : ContentPage
    {
        private SearchService _searchService;
        private List<SearchGroup> _searchGroups;
        public ListExcercisePage()
        {
            _searchService = new SearchService();
            InitializeComponent();
            PopulateListView(_searchService.GetRecentSearches());
        }

        private void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(e.NewTextValue));
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "OK");
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            // Note that we're using the text in the SearchBar while refreshing
            // the list of searches. This ensures that the filter is applied 
            // while refreshing the list. 
            PopulateListView(_searchService.GetRecentSearches(searchBar.Text));

            listView.EndRefresh();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            // Locally remove the search from search groups. Since SearchGroup
            // is an ObservableCollection, this will make the search item disappear
            // from the ListView immediately. 
            _searchGroups[0].Remove(search);

            // But we should also update the backend. So, we use SearchService for that.
            _searchService.DeleteSearch(search.Id);
        }

        // Note that we have re-used this method twice in this class. I noticed
        // I always had to set _searchGroups and immediately set listView.ItemsSource
        // together. So, I decided to refactor these few lines into a separate
        // method (PopulateListView) to make the code cleaner. 
        private void PopulateListView(IEnumerable<Search> searches)
        {
            _searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };

            listView.ItemsSource = _searchGroups;
        }
    }
}