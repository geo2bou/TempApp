using System;
using System.Collections.Generic;
using System.Linq;
using TempApp.Models;
using TempApp.ViewModels;
using Xamarin.Forms;

namespace TempApp.Views
{	
	public partial class NoteInfoPage : ContentPage
	{	
		public NoteInfoPage (NoteInfo noteInfo = null)
		{
			InitializeComponent();

            if (noteInfo != null)
            {
                ((AddOrEditNoteViewModel)BindingContext).Note = noteInfo;
            }
		}

        private void AddNote(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new AddOrEditNotePage());
        }

        private void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            NoteInfo noteInfo = ((NoteInfoViewModel)BindingContext).NoteList.Where(e => e.NoteId == (int)tappedEventArgs.Parameter).FirstOrDefault();

            Navigation.PushAsync(new AddOrEditNotePage());
        }

        private void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            TappedEventArgs tappedEventArgs = (TappedEventArgs)e;
            NoteInfo noteInfo = ((NoteInfoViewModel)BindingContext).NoteList.Where(e => e.NoteId == (int)tappedEventArgs.Parameter).FirstOrDefault();

            ((NoteInfoViewModel)BindingContext).NoteList.Remove(noteInfo);
        }
    }
}

