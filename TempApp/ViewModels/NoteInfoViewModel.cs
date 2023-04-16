using System;
using System.Collections.ObjectModel;
using TempApp.Models;

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
        }
    }
}

