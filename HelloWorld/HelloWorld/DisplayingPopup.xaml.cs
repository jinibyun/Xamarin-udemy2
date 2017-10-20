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
	public partial class DisplayingPopup : ContentPage
	{
		public DisplayingPopup ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // confirmation box
            //var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            //if (response)
            //{
            //   await DisplayAlert("Done", "Your response will be saved", "OK");
            //}

            // action sheet
            var response = await DisplayActionSheet("title", "cancel", "delete", "copy link", "message", "email");
            await DisplayAlert("resopnse", response, "OK");
        }
    }
}