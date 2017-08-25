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
	public partial class List1 : ContentPage
	{
		public List1 ()
		{
			InitializeComponent ();

            // ItemSource == BindingContext in xaml. therefore you do not have to do anything in xaml
            listview.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Jini", ImageUrl = "http://lorempixel.com/100/100/people/1", Status ="Let's talk" }
            };
        }
	}
}