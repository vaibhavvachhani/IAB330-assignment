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
    public partial class Weather : ContentPage
    {
        WeatherViewModel binding;
        public Weather()
        {
            InitializeComponent();
            binding = (WeatherViewModel)Content.BindingContext;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await binding.GetLocation();
        }
    }
}