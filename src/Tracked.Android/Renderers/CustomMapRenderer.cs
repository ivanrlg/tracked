﻿using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Tracked.Controls;
using Tracked.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace Tracked.Droid.Renderers {
    public class CustomMapRenderer : MapRenderer {
        private CustomMap customMap;

        public CustomMapRenderer(Context context) : base(context) {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e) {
            base.OnElementChanged(e);

            if (e.NewElement != null) {
                customMap = (CustomMap)e.NewElement;
            }
        }

        protected override void OnMapReady(GoogleMap map) {
            base.OnMapReady(map);

            NativeMap.UiSettings.ZoomControlsEnabled = !customMap.IsReadOnly;
        }

        protected override MarkerOptions CreateMarker(Pin pin) {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);

            if (pin is CustomMapPin customMapPin) {
                if (customMapPin.IsSpeedPin) {
                    marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.speed_icon));
                }

                if (customMapPin.IsJumpPin) {
                    marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.jump_icon));
                }

                marker.SetRotation(customMapPin.Rotation);
            }

            return marker;
        }
    }
}