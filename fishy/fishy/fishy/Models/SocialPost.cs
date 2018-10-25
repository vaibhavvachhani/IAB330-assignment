using fishy.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace fishy.Models
{
    public class SocialPost
    {
        public string Name { get; set; }
        public string ImageSource { get; set; }
        public string Location { get; set; }
        public string Time { get; set; }
        public SocialPost()
        {
            GoToProfile = new Command(ob => { OpenProfile(ob as SocialPost); });

        }
        private async void OpenProfile(SocialPost ob)
        {
            var x = ob.Name;
            await App.Current.MainPage.Navigation.PushAsync(new Gary_Profile(), true);
        }

        public ICommand GoToProfile { get; private set; }
    }



}
