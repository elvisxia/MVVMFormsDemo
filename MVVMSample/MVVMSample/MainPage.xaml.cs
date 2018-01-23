using MVVMSample.Model;
using MVVMSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMSample
{
	public partial class MainPage : ContentPage
	{

        MainPageViewModel ViewModel { get; set; }
		public MainPage()
		{
			InitializeComponent();
            ViewModel = new MainPageViewModel();
            this.BindingContext = ViewModel;
		}
        
    }
}
