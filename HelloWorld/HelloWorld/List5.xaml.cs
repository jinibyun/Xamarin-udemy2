using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class List5 : ContentPage
	{
		public List5 ()
		{
			InitializeComponent ();
		}

        private void listview_Refreshing(object sender, EventArgs e)
        {
            // refresh web service
            listview.ItemsSource = GetContacts();

            // one of either
            // listview.IsRefreshing = false;
            // to disable activate indicator
            listview.EndRefresh();
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            IEnumerable<Contact> contacts = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Jini", ImageUrl = "http://lorempixel.com/100/100/people/1", Status ="Let's talk" }
            };

            if (string.IsNullOrEmpty(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listview.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}