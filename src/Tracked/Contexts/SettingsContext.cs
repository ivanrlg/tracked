﻿using System;
using Xamarin.Essentials;

namespace Tracked.Contexts {
    public class SettingsContext {
        public SettingsContext() {
        }

        public bool IsDetectingJumps {
            get { return Preferences.Get("IsDetectingJumps", false); }
            set { Preferences.Set("IsDetectingJumps", value); }
        }

        public Guid? BluetoothDeviceId {
            get {
                if (Guid.TryParse(Preferences.Get("BluetoothDeviceId ", null), out Guid guid)) {
                    return guid;
                }

                return null;
            }
            set { Preferences.Set("BluetoothDeviceId ", value?.ToString()); }
        }
    }
}