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
	public partial class Data_ApplicationProperty : ContentPage
	{
		public Data_ApplicationProperty ()
		{
			InitializeComponent ();
            BindingContext = Application.Current;
            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationsEnabled;
        }

        private void OnChange(object sender, EventArgs e)
        {
            //var app = Application.Current as App;
            //app.Title = title.Text;
            //app.NotificationsEnabled = notificationsEnabled.On;

            // Application.Current.SavePropertiesAsync(); // immedeiately it will be saved as well
        }

        // when user away from this page, persistence will happen
        // more than two pages, it will be effective
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}