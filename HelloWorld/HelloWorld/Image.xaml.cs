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
	public partial class Image : ContentPage
	{
		public Image ()
		{
			InitializeComponent ();
            // var imageSource = (UriImageSource)ImageSource.FromUri(new Uri(""));
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false; // only code base (not xaml)
                                                // imageSource.CacheValidity = TimeSpan.FromHours(1); // default 24 hours

            image.Source = imageSource;
            // image.Source = "http://"; // implicity convert to UriImageSource
        }
    }
}