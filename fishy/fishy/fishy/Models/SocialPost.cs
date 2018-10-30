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
            if(x=="@Gary")
            {
            await App.Current.MainPage.Navigation.PushAsync(new Gary_Profile(), true);

            }
            else if(x=="@Kharghan")
            {
                await App.Current.MainPage.Navigation.PushAsync(new Khargan_Profile(), true);
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new Vaibhav_Profile(), true);
            }
        }

        public ICommand GoToProfile { get; private set; }
    }



}
