using fishy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fishy.ViewModels
{
    public class ViewCellViewModel
    {
        public ViewCellViewModel()
        {
            GoToProfile = new Command(OpenProfile);
        }


        private async void OpenProfile()
        {
            await App.Current.MainPage.Navigation.PushAsync(new User(), true);
        }

        public ICommand GoToProfile { get; private set; }
    }
}
