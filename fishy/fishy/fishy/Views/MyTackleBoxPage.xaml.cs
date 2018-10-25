using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fishy.Classes.Tacklebox_Classes;
using fishy.Models.Classes;
using fishy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyTackleBoxPage : ContentPage
	{
		public MyTackleBoxPage ()
		{
			InitializeComponent ();            
		}

        private async void MyRodsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.MyRodsPage());
        }

        private async void MyReelsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.MyReelsPage());
        }

        private async void MyLinesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.MyLinesPage());
        }

        private async void MyLuresPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new fishy.Views.MyLuresPage());
        }


    }
}