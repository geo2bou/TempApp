using System;
using System.Collections.Generic;
using TempApp.Models;
using TempApp.ViewModels;
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
			NoteInfo note = ((AddOrEditNoteViewModel)BindingContext).Note;

			if (note.NoteId == 0)
			{
				note.ImageUrl = "";
			}

			MessagingCenter.Send(this, "AddOrEditNote", note);
			Navigation.PopAsync();
		}
	}
}

