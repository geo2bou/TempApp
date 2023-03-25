using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TempApp.Views
{	
	public partial class HomePage : ContentPage
	{	
		public HomePage ()
		{
            //SetValue(NavigationPage.HasNavigationBarProperty, true);

            InitializeComponent();
		}

        async void Logout(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}

