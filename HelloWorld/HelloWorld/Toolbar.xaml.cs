﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Toolbar : ContentPage
    {
        public Toolbar()
        {
            InitializeComponent();
        }

        public void HandleClicked(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "Toolbar Activated", "ok");
        }
    }
}