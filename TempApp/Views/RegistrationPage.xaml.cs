using System;
using System.Collections.Generic;
using System.IO;
using SQLite;
using TempApp.Tables;
using Xamarin.Forms;

namespace TempApp.Views
{	
	public partial class RegistrationPage : ContentPage
	{	
		public RegistrationPage ()
		{
            InitializeComponent();
		}

        void Register(System.Object sender, System.EventArgs e)
        {
			var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "TempAppDatabase.db");
			var db = new SQLiteConnection(dbpath);
			db.CreateTable<RegistrationUserData>();

			var item = new RegistrationUserData()
			{
				Username = EntryUserName.Text,
				Password = EntryUserPassword.Text,
				Email = EntryUserEmail.Text,
				PhoneNumber = EntryUserPhoneNumber.Text
			};

			db.Insert(item);

			Device.BeginInvokeOnMainThread(async () =>
			{
				var result = await this.DisplayAlert("Congratulation", "User Registration Successfull", "Yes", "Cancel");

				if (result)
				{
					await Navigation.PushAsync(new LoginPage());
				}
			});
        }
    }
}

