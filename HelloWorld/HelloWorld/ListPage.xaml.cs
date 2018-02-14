using HelloWorld.Models;
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
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup> {

                new ContactGroup("A","A"){
                    new Contact{ Name="ABC", ImageUrl="https://lorempixel.com/100/100/people/1"},

                },

                new ContactGroup("D","D"){
                    new Contact{ Name="DEF", ImageUrl="https://lorempixel.com/100/100/people/2", Status="letsTalk"}
                }
            };
        }



    }
}
