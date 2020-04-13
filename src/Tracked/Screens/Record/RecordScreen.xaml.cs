﻿using System;
using Tracked.Contexts;
using Tracked.Models;
using Tracked.Utilities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracked.Screens.Record {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordScreen : ContentPage {
        public RecordScreen(MainContext context) {
            InitializeComponent();
            BindingContext = new RecordScreenViewModel(context);
        }

        public RecordScreenViewModel ViewModel => BindingContext as RecordScreenViewModel;

        protected override void OnAppearing() {
            base.OnAppearing();

            GeoUtility.Instance.Start();
        }

        protected override void OnDisappearing() {
            if (ViewModel.Status != RecordStatus.Running) {
                GeoUtility.Instance.Stop();
            }

            base.OnDisappearing();
        }

        private async void Start_Clicked(object sender, EventArgs e) {
            await ViewModel.Start();
        }

        private async void Stop_Clicked(object sender, EventArgs e) {
            await ViewModel.Stop();
            await Navigation.PopToRootAsync();
        }
    }
}