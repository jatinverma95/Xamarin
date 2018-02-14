using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HelloWorld.Exercises.Models
{
     class SearchGroup : ObservableCollection<Search>
    {

        public string RecentSearch { get; set; }

       public SearchGroup(string search)
        {
            this.RecentSearch = search;
        }
            

    }
}
