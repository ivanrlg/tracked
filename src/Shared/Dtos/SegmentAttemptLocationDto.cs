﻿using System;
using Shared.Interfaces;

namespace Shared.Dtos {
    public class SegmentAttemptLocationDto : ILatLng {
        public int SegmentAttemptLocationId { get; set; }
        public int SegmentAttemptId { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal AccuracyInMetres { get; set; }
        public decimal SpeedMetresPerSecond { get; set; }
        public decimal Altitude { get; set; }

        public decimal Mph => SpeedMetresPerSecond * 2.23694m;

        public override string ToString() {
            return $"{Timestamp}: Lat: {Latitude}, Lon: {Longitude}, Mph: {Mph}";
        }
    }
}
