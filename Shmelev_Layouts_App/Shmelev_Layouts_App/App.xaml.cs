﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shmelev_Layouts_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Valgusfoor2();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
