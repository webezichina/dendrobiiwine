﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile.Views.Customer
{
    public partial class CityListPage : ContentPage
    {
        public CityListPage()
        {
            InitializeComponent();
        }

        private async void OnSelectCity(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
