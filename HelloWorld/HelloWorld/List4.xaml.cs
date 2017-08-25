using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class List4 : ContentPage
	{
        // NOTE: ObservableCollection
        private ObservableCollection<Contact> _contacts;
        public List4 ()
		{
			InitializeComponent ();

            // ItemSource == BindingContext in xaml. therefore you do not have to do anything in xaml
            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Jini", ImageUrl = "http://lorempixel.com/100/100/people/1", Status ="Let's talk" }
            };
            listview.ItemsSource = _contacts;
        }

        // Context Action
        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        // Context Action
        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }
    }
}