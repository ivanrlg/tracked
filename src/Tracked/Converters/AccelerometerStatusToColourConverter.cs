﻿using System;
using System.Globalization;
using Tracked.Accelerometer;
using Xamarin.Forms;

namespace Tracked.Converters {
    public class AccelerometerStatusToColourConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is AccelerometerStatus status) {
                switch (status) {
                    case AccelerometerStatus.NotConnected:
                    case AccelerometerStatus.BluetoothTurnedOff:
                    case AccelerometerStatus.BluetoothTurningOn:
                        return Color.FromHex("#FF0000");
                    case AccelerometerStatus.Connecting:
                        return Color.FromHex("#ffa500");
                    case AccelerometerStatus.Connected:
                        return Color.FromHex("#00b300");
                    default:
                        break;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
