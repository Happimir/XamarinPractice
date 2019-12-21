using System;
using UdemyXamarin.AbsoluteLayoutExercise;
using UdemyXamarin.GridExercise;
using UdemyXamarin.ImageExercise;
using UdemyXamarin.RelativeLayoutExercise;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageGallery();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
