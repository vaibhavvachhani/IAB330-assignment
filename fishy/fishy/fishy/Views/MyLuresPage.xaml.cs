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
	public partial class MyLuresPage : ContentPage
	{
		public MyLuresPage ()
		{
			InitializeComponent ();
		}
        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as TackleBoxViewModel;
            var lure = e.Item as Lure;
            vm.HideOrShowLureDetails(lure);

        }
    }
}