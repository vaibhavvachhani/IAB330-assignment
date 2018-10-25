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
    public partial class AddNewLurePage : ContentPage
    {

        string lureType;
        int lureTypeIndex;
        bool showJigHeadOptions = false;

        public bool ShowJigHeadOptions { get => showJigHeadOptions; set => showJigHeadOptions = value; }


        public AddNewLurePage()
        {
            InitializeComponent();

            Lure_Type_Picker.Items.Add("Blades and Vibes");
            Lure_Type_Picker.Items.Add("Jigs");
            Lure_Type_Picker.Items.Add("HardBodies");
            Lure_Type_Picker.Items.Add("Skirted");
            Lure_Type_Picker.Items.Add("Slug");
            Lure_Type_Picker.Items.Add("Soft Plastics");
            Lure_Type_Picker.Items.Add("Spinner Bait");
            Lure_Type_Picker.Items.Add("Surface");

        }


        private void LureTypeSelected(object sender, EventArgs e)
        {
            lureType = Lure_Type_Picker.Items[Lure_Type_Picker.SelectedIndex];
            lureTypeIndex = Lure_Type_Picker.SelectedIndex;
            if (lureTypeIndex == 5)
            {
                ShowJigHeadOptions = true;
            }
            else
            {
                ShowJigHeadOptions = false;
            }
            
        }
        
        private void SaveNewLure(object sender, EventArgs e)
        {

            int Id = TackleBoxBaseClass.lures.Count;
            string Brand = Brand_Input.Text;
            string Model = Model_Input.Text;
            string LureType = lureType;
            int Weight = int.Parse(Weight_Input.Text);
            int Length = int.Parse(Length_Input.Text);
            string Colour = Colour_Input.Text;

            

            Lure newLure;
            if (lureTypeIndex ==5)
            {
                string JigHeadBrand = JigHeadBrand_Input.Text;
                int jigHeadWeight = int.Parse(jigHeadWeightInput.Text);
                int jigHeadHook = int.Parse(JigHeadHookSize_Input.Text);

                newLure = new Lure(Id, Brand, Model, LureType, Weight, Length, Colour, JigHeadBrand, jigHeadWeight, jigHeadHook);
                
            }
            else
            {
                newLure = new Lure(Id, Brand, Model, LureType, Weight,Length,Colour);
                

            }
            
            TackleBoxBaseClass.lures.Add(newLure);

            Navigation.PushAsync(new fishy.Views.Tacklebox());
        }
    }
}