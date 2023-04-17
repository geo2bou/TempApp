using System;
using System.Collections.ObjectModel;
using System.Linq;
using TempApp.Models;
using Xamarin.Forms;

namespace TempApp.ViewModels
{
	public class NoteInfoViewModel
	{
		public ObservableCollection<NoteInfo> NoteList { get; set; }

		public NoteInfoViewModel()
		{
			NoteList = new ObservableCollection<NoteInfo>();
			NoteList.Add(new NoteInfo() { NoteId = 1, Name = "Note1", Description = "NoteDesc1", ImageUrl = "" });
            NoteList.Add(new NoteInfo() { NoteId = 2, Name = "Note2", Description = "NoteDesc2", ImageUrl = "" });
            NoteList.Add(new NoteInfo() { NoteId = 3, Name = "Note3", Description = "NoteDesc3", ImageUrl = "" });
            NoteList.Add(new NoteInfo() { NoteId = 4, Name = "Note4", Description = "NoteDesc4", ImageUrl = "" });

			MessagingCenter.Subscribe<AddOrEditNoteViewModel, NoteInfo>(this, "AddOrEditNote", (page, note) =>
			{
				if (note.NoteId == 0)
				{
					note.NoteId = NoteList.Count + 1;
					NoteList.Add(note);
				}
				else
				{
					NoteInfo noteInfoForEdit = NoteList.Where(e => e.NoteId == note.NoteId).FirstOrDefault();

					int newIndex = NoteList.IndexOf(noteInfoForEdit);
					NoteList.Remove(noteInfoForEdit);

					NoteList.Add(note);

					int oldIndex = NoteList.IndexOf(note);
					NoteList.Move(oldIndex, newIndex);
				}
			});
        }
    }
}

