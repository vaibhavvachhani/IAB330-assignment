using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fishy.Classes.Tacklebox_Classes;
using fishy.Classes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tacklebox : ContentPage
	{
		public Tacklebox ()
		{
			InitializeComponent ();
            
		}

        private async void OpenMyTackleBoxPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.MyTackleBoxPage());
        }

        private async void OpenNewRodPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.AddNewRodPage());
        }

        private async void OpenNewReelPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.AddNewReelPage());
        }

        private async void OpenNewLinePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.AddNewLinePage());
        }

        private async void OpenNewLurePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.AddNewLurePage());
        }

    }
}