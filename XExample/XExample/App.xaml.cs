﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new XExample.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
//modificación local
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
