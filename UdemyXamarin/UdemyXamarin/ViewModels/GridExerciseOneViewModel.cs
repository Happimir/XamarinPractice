using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UdemyXamarin.ViewModels
{
    public class GridExerciseOneViewModel : BaseViewModel
    {
        private string _pinNumber;
        private ICommand tapCommand;
        private ICommand clearCommand;

        public GridExerciseOneViewModel(List<Button> buttons)
        {
            tapCommand = new Command(Tap);
            clearCommand = new Command(Clear);
        }

        public ICommand TapCommand {
            get { return tapCommand; }

            set {
                if (tapCommand == value){
                    return;
                }

                tapCommand = value;
                OnPropertyChanged("TapCommand");
            }
        }

        public ICommand ClearCommand {
            get { return clearCommand; }
            set {
                if(clearCommand == value)
                {
                    return;
                }

                clearCommand = value;
                OnPropertyChanged("ClearCommand");
            }
        }

        public string PinNumber {
            get { return _pinNumber; }
            set {
                _pinNumber = value;
                OnPropertyChanged("PinNumber");
            }
        }

        public void Clear()
        {
            _pinNumber = "";
            OnPropertyChanged("PinNumber");
        }

        public void Tap(object sender)
        {
            var item = (Button) sender;

             if(item.Text == "X")
            {
                if(PinNumber.Length > 0)
                {
                    _pinNumber = _pinNumber.Substring(0, _pinNumber.Length-1);
                }
            } else
            {
                _pinNumber += item.Text;
            }

            PinNumber = _pinNumber;
        }
    }
}
