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
	public partial class List2 : ContentPage
	{
		public List2 ()
		{
			InitializeComponent ();
            // ItemSource == BindingContext in xaml. therefore you do not have to do anything in xaml
            listview.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("M", "M")
                {
                    new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Major", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                },

                new ContactGroup("J", "J")
                {
                    new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Jini", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                },
            };
        }
	}
}