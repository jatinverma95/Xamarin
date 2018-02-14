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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //---------------------------1st part-------------------------
            //image.Source //this is type of ImageSource(Base class of all image sources also this is an Abstract class)

            ////Thus we can use it like,
            ////1.with FactoryMethods(complex):
            ////TypeCast because object returned from FromUri is of type (ImageSource) thus typecast
            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("http://..."));


            ////2.(easy method)
            //           var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            ////Property of UriImageSource(bydefault True), cached for 24 hours
            //           imageSource.CachingEnabled = false;
            //           imageSource.CacheValidity=TimeSpan.FromHours(1);//to change the cache time

            //           image.Source = imageSource;   //setting the Source of the image to the URI
            //image.Source="http://..." //this gets implicitly converted to the UriImageSource Object, that is why we can use like this directly in XAML.

            //image.Aspect = Aspect.AspectFill;// (Done in XAML)
            //-------------------------------2nd Part-----------------------

            ////EMBEDDDING THE IMAGE IN PCL:
            //image.Source=ImageSource.FromResource("HelloWorld.Images.background.jpg");

            //--------------------------------3rd Part------------------------

            ////TO ADD PLATFORM SPECIFIC IMAGES IN THE APP:
            btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
                iOS:"clock.png",
                Android:"clock.png",
                WinPhone:"Images/clock.png"
                ));

        }
    }
}