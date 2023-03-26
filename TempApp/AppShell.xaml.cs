using System;
using System.Collections.Generic;
using TempApp.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TempApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            InitRoutes();
        }

        private void InitRoutes()
        {
            Routing.RegisterRoute("home", typeof(HomePage));
        }

        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            await SecureStorage.SetAsync(App.REMEMBER_ME, false.ToString());
            await Shell.Current.GoToAsync("///login");
            Shell.SetFlyoutBehavior(Shell.Current, FlyoutBehavior.Disabled);
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}

