using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MVVMSample.Controls;
using MVVMSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(MyCheckBox),typeof(MyCheckBoxRenderer))]
namespace MVVMSample.Droid
{
    public class MyCheckBoxRenderer:ViewRenderer<MyCheckBox,CheckBox>
    {
        Context baseContext;
        public MyCheckBoxRenderer(Context context) : base(context)
        {
            baseContext = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyCheckBox> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                CheckBox cb = new CheckBox(baseContext);
                cb.Checked = e.NewElement.IsChecked;
                this.SetNativeControl(cb);
            }
           
            
        }
    }
}