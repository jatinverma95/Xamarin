using HelloWorld.Exercises.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace HelloWorld.Exercises.Services
{
    public class SearchService
    {
        private ObservableCollection<Search> searches = new ObservableCollection<Search> {
            new Search{Id=1 ,Location="Delhi", CheckIn="Jan 1,2018", CheckOut="Jan 30,2018" },
            new Search{Id=2 ,Location="Mumbai", CheckIn="Feb 1,2018", CheckOut="Feb 30,2018" },
            new Search{Id=3 ,Location="Pune", CheckIn="March 1,2018", CheckOut="March 30,2018" }
        };

        internal ObservableCollection<Search> Searches { get => searches; set => searches = value; }

        public ObservableCollection<Search> GetSearches(string filter = null)
        {

            if (filter == null)
                return Searches;
            return new ObservableCollection<Search>(Searches.Where(c => c.Location.StartsWith(filter)));
        }

        public void DeleteSearch(int searchId)
        {
            foreach (var element in searches)
            {
                if (element.Id == searchId)
                {
                    searches.Remove(element);
                    searches.ToString();
                    break;
                }
            }


        }
    }
}
