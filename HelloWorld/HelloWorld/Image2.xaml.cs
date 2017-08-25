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
	public partial class Image2 : ContentPage
	{
		public Image2 ()
		{
			InitializeComponent ();
            // note: see full qualified name from dependent project (android or ios)
            // image.Source = ImageSource.FromResource("HelloWorld.Droid.Images.background.jpg");
        }
    }
}