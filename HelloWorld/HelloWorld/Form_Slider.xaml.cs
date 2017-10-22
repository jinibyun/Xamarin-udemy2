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
	public partial class Form_Slider : ContentPage
	{
		public Form_Slider ()
		{
			InitializeComponent ();
		}
        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}