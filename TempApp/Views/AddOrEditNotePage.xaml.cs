using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TempApp.Views
{	
	public partial class AddOrEditNotePage : ContentPage
	{	
		public AddOrEditNotePage ()
		{
			InitializeComponent ();
		}

		private void SaveNote(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}

