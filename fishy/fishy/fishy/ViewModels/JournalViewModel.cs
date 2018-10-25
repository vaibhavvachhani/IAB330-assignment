using fishy.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace fishy.ViewModels
{
    public class JournalViewModel : BaseViewModel
    {
        public JournalViewModel() {
            entries = new ObservableCollection<Entry>();
       
        }
        public static ObservableCollection<Entry> entries { get; set; }

        public ObservableCollection<Entry> Entries
        {
            get
            {
                return entries;
            }
            set {

                entries = value;
                OnPropertyChanged();

            }
        }
    }
}
