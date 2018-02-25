using HelloWorld.Exercises.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Exercises.Services
{
    class ActivityService
    {
        private static List<Activity> listt = new List<Activity> {
            new Activity{UserId=1, Description="Your FB Friend ABC Singh is on MyInstagram"},
            new Activity{UserId=2, Description="DEF Singh is following you on MyInstagram"},
            new Activity{UserId=3, Description="Your FB Friend GHI Singh is on MyInstagram"},
            new Activity{UserId=4, Description="Your FB Friend JKL Singh liked your photo"},
            new Activity{UserId=5, Description="MNO Singh sent a photo on MyInstagram"},
            new Activity{UserId=6, Description="Your FB Friend PQR Singh is on MyInstagram"},
            new Activity{UserId=7, Description="STU Singh liked your photo"},
            new Activity{UserId=8, Description="Your FB Friend VWX Singh is on MyInstagram"},
            new Activity{UserId=9, Description="Your FB Friend YZ Singh is on MyInstagram"},
        };

        public static List<Activity> GetActivity()
        {
            return listt;
        }

    }
}
