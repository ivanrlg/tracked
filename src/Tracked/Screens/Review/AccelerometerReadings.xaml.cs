﻿using Tracked.Contexts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracked.Screens.Review {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerometerReadingsScreen : ContentPage {
        public AccelerometerReadingsScreen(MainContext context) {
            InitializeComponent();
            BindingContext = new AccelerometerReadingsScreenViewModel(context, null);
        }
    }
}