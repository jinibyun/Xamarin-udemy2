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
    public partial class Navigation2 : ContentPage
    {
        public Navigation2()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PopAsync();
            await Navigation.PopModalAsync();
        }

        // note: disable android device back button (built-in) especailly this is useful with OpoModalAsync as above
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}