using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormElements : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public FormElements()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
                picker.Items.Add(method.Name);
        }

        //switch
        public void HandleToggled(object sender, ToggledEventArgs e)
        {
            //label.IsVisible = e.Value;
        }

        //slider
        public void HandleValueChanged(object sender, ValueChangedEventArgs e)
        {
            //e.OldValue
            //e.NewValue
        }

        //Entry
        public void HandleCompleted(object sender, EventArgs e)
        {
            label2.Text = "Completed";
        }

        //Entry
        public void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            label2.Text = e.NewTextValue;
        }

        //Picker
        public void HandleSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod> {
              new ContactMethod{ Id=1, Name="Phone"},
              new ContactMethod{ Id=1, Name="Fax"}
            };
        }

        public void HandleDateSelected(object sender, DateChangedEventArgs e)
        {
            
        }

    }
}