﻿using Application = Microsoft.Maui.Controls.Application;
namespace MauiBlazor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}