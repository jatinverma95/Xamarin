﻿using HelloWorld.Models;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld.MasterrDetailPage
{
	public partial class ContactsPage : MasterDetailPage
	{
		 void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false;    //check if isMasterPresented? if false hides the master in vertical mode 
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

