using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {

        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            //TO WRITE DEVICE SPECIFIC CODE in cs, Though these UI changes should be done by XAML:

            //1.
            //if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(10, 20, 0, 0);

            //2.
            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0)
            //);

            //3.
            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    },
            //Android: () =>
            //{
            //});


        }

        //void HandleChange(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{                                      //Defining No. upto 2 decimal places.
        //    label.Text = String.Format("Value is {0:F2}", e.NewValue);
        //} 


    }
}