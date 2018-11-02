using fishy.Models;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fishy.ViewModels
{
    public class JournalEntryViewModel : BaseViewModel
    {
       
        private string caption;
        private string species;
        //private string imageSource;
        private string address;
        public string Caption
        {
            get
            {
                return caption;
            }
            set
            {
                caption = value;
                OnPropertyChanged();
            }
        }

        public string Species {
            get
            {
                return species;
            }
            set
            {
                species = value;
                OnPropertyChanged();

            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public JournalEntryViewModel()
        {
            SelectPhotoCommand = new Command(SelectPhoto);
            CreateEntryCommand = new Command(CreateEntry);
        }

        private string imageSource = "fish.png";

        public string ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                imageSource = value;
                OnPropertyChanged();
            }
        }
        private async void SelectPhoto()
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions());

            if (file != null)
            {
                ImageSource = file.Path;

            }
        }

        public ICommand SelectPhotoCommand { get; private set; }



        public ICommand CreateEntryCommand { get; private set; }

       
        
        private async void CreateEntry()

        {
            Models.Entry entry1 = new Models.Entry(ImageSource=ImageSource,Caption=Caption,Address=Address,Species= Species);
            JournalViewModel.entries.Add(entry1);
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
