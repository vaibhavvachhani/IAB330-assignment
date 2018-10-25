using fishy.Classes.Tacklebox_Classes;
using fishy.Models.Classes;
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
	public partial class AddNewLinePage : ContentPage
	{
        string LineType;
        string LineUse;

        public AddNewLinePage ()
		{
			InitializeComponent ();
            Line_Type_Picker.Items.Add("Braid");
            Line_Type_Picker.Items.Add("Monofilament");
            Line_Type_Picker.Items.Add("Flurocarbon");

            Line_Use_Picker.Items.Add("Main Line");
            Line_Use_Picker.Items.Add("Leader Line");
		}

        private void LineTypeSelected(object sender, EventArgs e)
        {
            LineType = Line_Type_Picker.Items[Line_Type_Picker.SelectedIndex];
            
        }
        private void LineUseSelected(object sender, EventArgs e)
        {
            LineUse = Line_Use_Picker.Items[Line_Use_Picker.SelectedIndex];
            
        }


        private void SaveNewReel(object sender, EventArgs e)
        {
            int Id = TackleBoxBaseClass.line.Count;
            string Brand = Brand_Input.Text;
            string Model = Model_Input.Text;
            int Strength = int.Parse(Strength_Input.Text);
            


            Line newLine = new Line(Id, Brand, Model, LineType, Strength,LineUse);
            TackleBoxBaseClass.line.Add(newLine);

            Navigation.PushAsync(new fishy.Views.Tacklebox());

        }
    }
}