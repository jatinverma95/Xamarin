using HelloWorld.Exercises.Models;
using HelloWorld.Exercises.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AirbnbSearchList : ContentPage
    {
        public SearchService ss = new SearchService();
        SearchGroup searchGrp;
        ObservableCollection<SearchGroup> searchElement;


        public AirbnbSearchList()
        {
            InitializeComponent();

            ObservableCollection<Search> list = ss.GetSearches();

            searchGrp = new SearchGroup("Recent Searches");

            foreach (var listItem in list)
            {
                searchGrp.Add(listItem);
            }

            searchElement = new ObservableCollection<SearchGroup>
            {
                searchGrp
            };

            listView.ItemsSource = searchElement;

        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = "";
            for (int i = 0; i < e.NewTextValue.Length; i++)
            {
             
                if (i == 0)
                {
                    searchText += (e.NewTextValue[i].ToString()).ToUpper();
                }
                else
                {
                    searchText += (e.NewTextValue[i].ToString()).ToLower();
                }
            }

            ObservableCollection<Search> list = ss.GetSearches(searchText);
            searchGrp = new SearchGroup("Recent Searches");

            foreach (var listItem in list)
            {
                searchGrp.Add(listItem);
            }

            searchElement = new ObservableCollection<SearchGroup>
            {
                searchGrp
            };

            listView.ItemsSource = searchElement;
        }

        void Handle_Refresh(object sender, EventArgs e)
        {
            listView.ItemsSource = searchElement;
            listView.EndRefresh();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var search = e.Item as Search;
            DisplayAlert("Location", search.Location, "OK");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            for (int i = 0; i < searchElement.Count; i++)
            {
                if (searchElement[i].RecentSearch == "Recent Searches")
                {
                    searchElement[i].Remove(search);
                }

            }

            ss.DeleteSearch(search.Id);


        }
    }
}