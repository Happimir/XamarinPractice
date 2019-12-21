using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UdemyXamarin.ViewModels
{
    public class GreetPageViewModel : BaseViewModel
    {
        private double _value;
        private int stepValue;
        public GreetPageViewModel()
        {
            stepValue = 5;
        }

        public double SliderValue {
            get { return _value; }
            set {
                var val = Math.Round(value / stepValue) * stepValue;
                if(_value == val)
                {
                    return;
                }
                _value = val;
                OnPropertyChanged("SliderValue");
            }
        }

    }
}
