using HelloWorld.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NoticationEnabledKey = "NoticationEnabled";

        public App()
        {
            InitializeComponent();
            // For testing each page, uncomment only one at a time

            // MainPage = new HelloWorld.MainPage();
            // MainPage = new GreetPage();
            // MainPage = new StackPage();
            // MainPage = new AbsolutePage();
            // MainPage = new AbsoluteLayoutExercise1();
            // MainPage = new AbsoluteLayoutExercise2();
            // MainPage = new RelativePage();
            // MainPage = new ReleativeLayoutExercise1();
            // MainPage = new GridExercise1();
            // MainPage = new GridExercise2();
            // MainPage = new Image();

            // ref: https://developer.xamarin.com/guides/xamarin-forms/user-interface/images/#Embedded_Images
            // MainPage = new Image2();
            // MainPage = new ImageExercise();
            // MainPage = new List1();
            // MainPage = new List2();
            // MainPage = new List3();
            // MainPage = new List4();
            // MainPage = new List5();
            // MainPage = new ListExcercisePage();

            //MainPage = new NavigationPage(new Navigation_Intro())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};
            // MainPage = new NavigationPage(new ContactMasterPage());
            // MainPage = new ContactMasterPage2();
            // MainPage = new Tab1();
            // MainPage = new Carousel1();
            // MainPage = new DisplayingPopup();
            // note: toolbar items should be wrapped up with Navigationpage as below
            // MainPage = new NavigationPage(new ToolbarItem1());
            // MainPage = new NavigationPage(new NavigationExercise());

            // MainPage = new Form_Switch();
            // MainPage = new Form_Slider();
            // MainPage = new Form_Stepper();
            // MainPage = new Form_Entries();
            // MainPage = new Form_Picker();
            // MainPage = new Form_Picker2();
            // MainPage = new Form_TableView();
            // MainPage = new NavigationPage(new ContactsPageExercise());

            // NOTE: for data access, test only for web api
            // MainPage = new Data_ApplicationProperty(); // skip
            // MainPage = new Data_Sqlite(); // skip

            // MainPage = new Data_RestfulWebService();
            MainPage = new NavigationPage(new Data_RestfulWebServiceExercise()); // using netflix api. Actually end point for netflex is gone, therefore it would not work
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
