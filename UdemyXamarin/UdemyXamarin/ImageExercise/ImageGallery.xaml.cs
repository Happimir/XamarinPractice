using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.ViewModels.ImageGallery;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin.ImageExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageGallery : ContentPage
    {
        private ImageGalleryViewModel viewModel;
        public ImageGallery()
        {
            InitializeComponent();
            viewModel = new ImageGalleryViewModel();
            BindingContext = viewModel;
        }
    }
}