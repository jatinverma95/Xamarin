using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutExercise : ContentPage
    {
        public StackLayoutExercise()
        {
            InitializeComponent();

            var layout = new StackLayout
            {
                VerticalOptions = Xamarin.Forms.LayoutOptions.Center,
                Spacing = 10
            };

            layout.Children.Add(new Label
            {
                Text = "Welcome to Xamarin",
                TextColor = Xamarin.Forms.Color.White,
                FontSize = 30,
                FontAttributes = Xamarin.Forms.FontAttributes.Bold,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center
            });

            layout.Children.Add(new Label
            {
                Text = "Cross-platform apps made easy",
                TextColor = Xamarin.Forms.Color.White,
                FontSize = 18,
                HorizontalOptions = Xamarin.Forms.LayoutOptions.Center
            });

            layout.Children.Add(new Button
            {
                Text = "Login",
                BackgroundColor = Xamarin.Forms.Color.FromHex("1dabf0"),
                TextColor = Xamarin.Forms.Color.White

            });

            layout.Children.Add(new Button
            {
                Text = "Register",
                BackgroundColor = Xamarin.Forms.Color.FromHex("1dabf0"),
                TextColor = Xamarin.Forms.Color.White
            });


            Content = layout;

        }
    }
}