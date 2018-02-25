using HelloWorld.Exercises.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Exercises.InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(User user)
        {

            if (user == null)
                throw new ArgumentNullException();

            InitializeComponent();

            BindingContext = user;
        }
    }
}