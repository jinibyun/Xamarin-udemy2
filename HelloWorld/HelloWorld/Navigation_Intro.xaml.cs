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
    public partial class Navigation_Intro : ContentPage
    {
        public Navigation_Intro()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new Navigation2());
            await Navigation.PushModalAsync(new Navigation2());
        }
    }
}