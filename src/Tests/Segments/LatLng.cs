﻿using Shared.Interfaces;

namespace Tests.Segments {
    public class LatLng : ILatLng {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LatLng(double latitude, double longitude) {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
