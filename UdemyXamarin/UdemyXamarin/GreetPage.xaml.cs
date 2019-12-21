using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        private GreetPageViewModel viewModel;
        public GreetPage()
        {
            InitializeComponent();
            viewModel = new GreetPageViewModel();
            viewModel.SliderValue = slider.Value;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = viewModel;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            BindingContext = null;
        }
    }
}