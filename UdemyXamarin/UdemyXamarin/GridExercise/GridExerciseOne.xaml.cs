using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyXamarin.GridExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridExerciseOne : ContentPage
    {
        private string Pin = "";
        private GridExerciseOneViewModel viewModel;
        public GridExerciseOne()
        {
            InitializeComponent();

            var items = 
                
                MyGrid.Children
                .Where(x => x.GetType() == typeof(Button))
                .Select(x => (Button)x)
                .ToList();

            viewModel = new GridExerciseOneViewModel(items);
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