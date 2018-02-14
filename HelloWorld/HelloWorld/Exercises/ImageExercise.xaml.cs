using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExercise : ContentPage
    {
        static int imgNo = 0;

        public ImageExercise()
        {
            InitializeComponent();

        }

        void handleClickLeft(object sender, EventArgs e)
        {
            if (imgNo == 0)
            {
                imgNo = 10;
            }
            else {
                imgNo--;
            }
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/" + imgNo) };
            imageSource.CachingEnabled = false;

            image.Source = imageSource;
            imgLabel.Text = imgNo.ToString();
        }


        void handleClickRight(object source, EventArgs e)
        {
            if (imgNo == 10)
            {
                imgNo = 0;
            }
            else
            {
                imgNo++;
            }
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/city/" + imgNo) };
            imageSource.CachingEnabled = false;

            image.Source = imageSource;
            imgLabel.Text = imgNo.ToString();

        }
    }
}