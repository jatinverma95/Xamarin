using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Exercises.Models
{
    public class Search
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }


        public string NewProperty
        {
            get
            {
                return string.Format("{0} - {1} / {2}", CheckIn, CheckOut, Location);
            }
        }

    }
}
