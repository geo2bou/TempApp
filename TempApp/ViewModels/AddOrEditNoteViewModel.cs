using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TempApp.Models;

namespace TempApp.ViewModels
{
	public class AddOrEditNoteViewModel : INotifyPropertyChanged
	{
		public NoteInfo _noteInfo;

		public NoteInfo Note
		{ 
			get { return _noteInfo; }
			set
			{
				_noteInfo = value;
				OnPropertyChanged();
			}
		}

        public AddOrEditNoteViewModel()
		{
			Note = new NoteInfo();
		}

		public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

