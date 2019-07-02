﻿using MtbMate.Contexts;
using MtbMate.Models;
using MtbMate.Screens;
using MtbMate.Screens.Bluetooth;
using MtbMate.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MtbMate.Home
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(MainContext context) : base(context)
        {
        }

        public ObservableCollection<RideModel> Rides => Context.Model.Rides.ToObservable();

        public bool HasRides => Rides.Any();

        public async Task GoToBluetoothSettings(INavigation nav)
        {
            await nav.PushAsync(new BluetoothSetupScreen(Context));
        }

        public async Task CreateRide()
        {
            await Context.Model.AddRide(new RideModel
            {
                Name = "Test",
            });
            await Context.Model.AddRide(new RideModel
            {
                Start = DateTime.UtcNow,
            });

            OnPropertyChanged();
        }
    }
}