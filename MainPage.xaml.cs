﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("Caprasimo-Regular.ttf", Alias = "Caprasimo")]
[assembly: ExportFont("Lexend-Regular.ttf", Alias = "Lexend")]

namespace App11
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void MovePage(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Page1());
        }

        public void MoveTo(object obj, EventArgs args)
        {
            Navigation.PushAsync(new Horas());
        }
    }
}