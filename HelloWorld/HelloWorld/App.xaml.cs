﻿using HelloWorld.Exercise;
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

            MainPage = new ListExcercisePage();

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
