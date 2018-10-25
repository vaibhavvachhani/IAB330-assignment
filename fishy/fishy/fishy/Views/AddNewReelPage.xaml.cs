using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fishy.Classes.Tacklebox_Classes;
using fishy.Models.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fishy.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddNewReelPage : ContentPage
	{
        string selectedreelType;
		public AddNewReelPage ()
		{
			InitializeComponent ();
            Reel_Type_Input.Items.Add("Alvey");
            Reel_Type_Input.Items.Add("Bait Caster");
            Reel_Type_Input.Items.Add("Over Head");
            Reel_Type_Input.Items.Add("Spinning");

        }

        private void ReelTypeSelected(object sender, EventArgs e)
        {
            selectedreelType = Reel_Type_Input.Items[Reel_Type_Input.SelectedIndex];
            Console.Write(selectedreelType);
        }

        private void SaveNewReel(object sender, EventArgs e)
        {
            int Id = TackleBoxBaseClass.reels.Count;
            string Brand = Brand_Input.Text;
            string Model = Model_Input.Text;
            int Size = int.Parse(Size_Input.Text);
            

            Reel newReel = new Reel(Id,Brand,Model,Size,selectedreelType);
            TackleBoxBaseClass.reels.Add(newReel);
            
            Navigation.PushAsync(new fishy.Views.Tacklebox());
               
        }
    }
}