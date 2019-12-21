using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin.ImageExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageExcerciseOne : ContentPage
    {
        public ImageExcerciseOne()
        {
            InitializeComponent();
            
            //var source = new UriImageSource { 
            //    Uri = new Uri("https://lorempixel.com/1920/1080/sports/7/")
            //    };

            //source.CachingEnabled = false;

            //ImageOne.Source = source;
        }
    }
}