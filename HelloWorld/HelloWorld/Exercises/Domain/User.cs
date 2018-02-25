using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Exercises.Domain
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get => "http://lorempixel.com/200/200/people/{UserId}";
        }
    }
}