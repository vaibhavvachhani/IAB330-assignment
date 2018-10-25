using fishy.Classes.Tacklebox_Classes;
using fishy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyReelsPage : ContentPage
	{
		public MyReelsPage ()
		{
			InitializeComponent ();
		}

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as TackleBoxViewModel;
            var reel = e.Item as Reel;
            vm.HideorShowReelDetails(reel);

        }
    }
}