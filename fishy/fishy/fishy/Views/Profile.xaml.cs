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
	public partial class Profile : ContentPage
	{
        ProfileViewModel viewModel;
		public Profile ()
		{
			InitializeComponent ();
            viewModel = new ProfileViewModel();
            BindingContext = viewModel;
		}

    }
}