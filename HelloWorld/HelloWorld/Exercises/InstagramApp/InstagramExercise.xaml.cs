using HelloWorld.Exercises.Domain;
using HelloWorld.Exercises.Services;
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
    public partial class InstagramExercise : TabbedPage
    {
        public InstagramExercise()
        {
            InitializeComponent();

            listView.ItemsSource = ActivityService.GetActivity();
        }

        async public void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            Activity activityUser = e.SelectedItem as Activity;
            var user = UserService.GetUser(activityUser.UserId);

            await Navigation.PushAsync(new ProfilePage(user));

            listView.SelectedItem = null;

        }


    }


}