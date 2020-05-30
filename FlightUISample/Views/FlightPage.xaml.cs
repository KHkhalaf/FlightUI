using FlightUISample.ViewModels;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FlightUISample.Views
{
    public partial class FlightPage : ContentPage
    {
        public FlightPage()
        {
            InitializeComponent();
            BindingContext = new FlightViewModel();
        }
    }
}
