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
	public partial class MyLinesPage : ContentPage
	{
		public MyLinesPage ()
		{
			InitializeComponent ();
		}

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as TackleBoxViewModel;
            var line = e.Item as Line;
            vm.HideOrShowLineDetails(line);

        }
    }
}