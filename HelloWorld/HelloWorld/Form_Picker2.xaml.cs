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
	public partial class Form_Picker2 : ContentPage
	{
		public Form_Picker2 ()
		{
			InitializeComponent ();
		}

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //e.NewDate
        }
    }
}