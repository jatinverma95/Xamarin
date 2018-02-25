using HelloWorld.Models;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld.SimpleMasterrDetailPage
{
     //In this App, it is for SIMPLE NAVIGATION from one page to other and sending DATA from one to another page, 
     //THERE IS NO USE OF MASTERDETAILPAGE IN THIS.

	public partial class ContactsPage : ContentPage
	{
		async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			var contact = e.SelectedItem as Contact;
			await Navigation.PushAsync(new ContactDetailPage(contact));
			listView.SelectedItem = null;
		}

		public ContactsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact> {
				new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
				new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
			};
		}
	}
}

