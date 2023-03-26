using System;
using System.Diagnostics;
using TempApp.common;
using TempApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TempApp
{
    public partial class App : Application
    {
        public static string REMEMBER_ME = "remember_me";

        public App ()
        {
            StyleSheetRegistrar.RegisterStyle("-xf-horizontal-options", typeof(VisualElement), nameof(View.HorizontalOptionsProperty));
            StyleSheetRegistrar.RegisterStyle("-xf-shell-navbarhasshadow", typeof(Shell), nameof(Shell.NavBarHasShadowProperty));

            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new NavigationPage(new LoginPage());

            this.RequestedThemeChanged += App_RequestedThemeChanged;
        }

        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            Debug.WriteLine($"Requested: {e.RequestedTheme}");
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

