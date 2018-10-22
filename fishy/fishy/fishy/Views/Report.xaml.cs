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
	public partial class Report : ContentPage
	{
		public Report ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
           DisplayAlert("Successful", "Your review has been submitted.", "OK");
            
        }
    }
}