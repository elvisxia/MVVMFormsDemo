using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVMSample.Controls
{
    public class MyCheckBox:View
    {
        public bool IsChecked {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(
            propertyName: "IsChecked",
            returnType: typeof(bool),
            declaringType: typeof(MyCheckBox),
            defaultValue: false);
    }
}
