using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListSelection : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        ObservableCollection<Contact> GetContacts(string searchText = null)
        {
            if (searchText == null)
            {
                return _contacts;
            }
            else {
                var list = new List<Contact>(_contacts);

                return new ObservableCollection<Contact>(list.Where(c=>c.Name.StartsWith(searchText)));
            }
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        void Handle_Refresh(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }


        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        public ListSelection()
        {
            InitializeComponent();
            _contacts = new ObservableCollection<Contact>
            {
                new Contact{Name="Jatin", Status="lets Learn", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new Contact{Name="Verma", Status="lets Learn More", ImageUrl="http://lorempixel.com/100/100/people/2"}
            };

            listView.ItemsSource = _contacts;
        }
    }
}