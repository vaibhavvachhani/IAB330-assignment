using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace fishy.Views
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
            Children.Add(new Home());
            Children.Add(new Journal());
            Children.Add(new Tacklebox());
            Children.Add(new Social());
            Children.Add(new Profile());

            
        }
	}
}
