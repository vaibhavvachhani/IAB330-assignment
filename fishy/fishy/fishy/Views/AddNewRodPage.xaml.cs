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
    public partial class AddNewRodPage : ContentPage
    {
        
        public AddNewRodPage()
        {
            InitializeComponent();
        }


        private void SaveNewRod(object sender, EventArgs e)
        {    
            
            int id = TackleBoxBaseClass.rods.Count;

            //get inputs from form to use for mew rod
            string brand = Brand_Input.Text;
            string model = Model_Input.Text;
            int feet = int.Parse(Length_Input_Feet.Text);
            int inches = int.Parse(Length_Input_Inches.Text);
            int weightLow = int.Parse(Weight_Input_Low.Text);
            int weightHigh = int.Parse(Weight_Input_High.Text);
            int lureWeightLow = int.Parse(LureWeight_Input_Low.Text);
            int lureWeightHigh = int.Parse(LureWeight_Input_High.Text);


            //create the new rod
            Rod Newrod = new Rod(id,brand,model,feet,inches,weightLow,weightHigh,lureWeightLow,lureWeightHigh);
            //add the new rod to the list of rods
            TackleBoxBaseClass.rods.Add(Newrod);

            Navigation.PushAsync(new fishy.Views.Tacklebox());


        }

    }
}