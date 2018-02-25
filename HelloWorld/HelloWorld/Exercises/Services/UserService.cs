using HelloWorld.Exercises.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Exercises.Services
{
    class UserService
    {
        private static List<User> listt = new List<User>
        {
            new User{ id=1, Name="ABC Singh", Description="My name is ABC Singh"},
            new User{ id=2, Name="DEF Singh", Description="My name is DEF Singh"},
            new User{ id=3, Name="GHI Singh", Description="My name is GHI Singh"},
            new User{ id=4, Name="JKL Singh", Description="My name is JKL Singh"},
            new User{ id=5, Name="MNO Singh", Description="My name is MNO Singh"},
            new User{ id=6, Name="PQR Singh", Description="My name is PQR Singh"},
            new User{ id=7, Name="STU Singh", Description="My name is STU Singh"},
            new User{ id=8, Name="VWX Singh", Description="My name is VWX Singh"},
            new User{ id=9, Name="YZ Singh", Description="My name is YZ Singh"},
        };



        public static User GetUser(int id)
        {
            return listt.SingleOrDefault(c => c.id == id) ;
        }
    }
}
