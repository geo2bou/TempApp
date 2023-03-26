using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using TempApp.Tables;
using Xamarin.Forms;

namespace TempApp.Views
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			SetValue(NavigationPage.HasNavigationBarProperty, false);

			InitializeComponent();
		}

        async void Login(System.Object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TempAppDatabase.db");
            var db = new SQLiteConnection(dbpath);
			var query = db.Table<RegistrationUserData>().Where(r => r.Username.Equals(EntryUser.Text) && r.Password.Equals(EntryPassword.Text)).FirstOrDefault();

			if (query != null)
			{
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
			{
				Device.BeginInvokeOnMainThread(async () =>
				{
					var result = await this.DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");

					if (result)
					{
						await Navigation.PushAsync(new LoginPage());
					}
					else
					{
						await Navigation.PushAsync(new LoginPage());
					}
				});
			}
        }

        async void Signup(System.Object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new RegistrationPage());
		}
    }
}

