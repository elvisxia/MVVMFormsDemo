using MVVMSample.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVMSample.ViewModels
{
    public class MainPageViewModel
    {
        public StackLayout CheckBoxList { get; set; }
        public MainPageViewModel()
        {
            //You can modify the codes as you want
            CheckBoxList = new StackLayout();
            for (int i = 0; i < 30; i++)
            {
                CheckBoxList.Children.Add(new MyCheckBox { IsChecked = i % 2 == 1 ? true : false });
            }
        }
    }
}
