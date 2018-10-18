using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fishy.ViewModels
{
    public class ProfileViewModel : BaseViewModel

    {
        private string sourceString = "http://profilepicturesdp.com/wp-content/uploads/2018/06/default-profile-picture-gmail-2.png";

        public string SourceString{
            get
            {
                return sourceString;
            }
            set
            {
                sourceString = value;
                OnPropertyChanged();
            }
        }
        public ProfileViewModel()
        {
            SelectPhotoCommand = new Command(SelectPhoto);
        }
       

        private async void SelectPhoto()
        {
            await CrossMedia.Current.Initialize();

            var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions());

            if (file != null)
            {
                SourceString = file.Path;

            }
        }

        public ICommand SelectPhotoCommand { get; private set; }



    }

}
