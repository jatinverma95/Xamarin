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
    public partial class Popups : ContentPage
    {
        public Popups()
        {
            InitializeComponent();
        }

        async public void handleClicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are you sure", "Yes", "No");
            if (response)
            {
                DisplayAlert("Done", "Your response will be saved", "OK"); //No await here because
                //dont have to wait for the response as no lines below this.
            }
        }

        async public void handleActionSheetClick(object sender, EventArgs e)
        {
            var response = await DisplayActionSheet("Tiele", "Cancel", "Delete", "copyLink", "Message", "Email");
            DisplayAlert("Respose", response, "OK");
        }

    }
}