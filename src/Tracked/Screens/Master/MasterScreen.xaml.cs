﻿
using Tracked.Contexts;
using Tracked.Home;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tracked.Screens.Master {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterScreen : MasterDetailPage {
        public MasterScreen(MainContext context) {
            InitializeComponent();

            Master = new MainMenu(context);
            Detail = new NavigationPage(new MainPage(context)) {
                BarBackgroundColor = Color.FromHex("#080870"),
                BarTextColor = Color.White,
            };
        }
    }
}