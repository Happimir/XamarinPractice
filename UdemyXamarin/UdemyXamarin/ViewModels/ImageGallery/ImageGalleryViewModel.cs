using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UdemyXamarin.ViewModels.ImageGallery
{
    public class ImageGalleryViewModel : BaseViewModel
    {
        private ICommand backCommand;
        private ICommand nextCommand;

        private int sourceIndex = 1;
        private string urlSource = $"https://lorempixel.com/1920/1080/sports/1/";

        public ImageGalleryViewModel()
        {
            backCommand = new Command(Back);
            nextCommand = new Command(Next);
        }

        public ICommand BackCommand {
            get { return backCommand; }
            set {
                if(backCommand == value)
                {
                    return;
                }

                backCommand = value;
                OnPropertyChanged("BackCommand");
            }
        }

        public ICommand NextCommand {
            get { return nextCommand; }
            set {
                if(nextCommand == value)
                {
                    return;
                }

                nextCommand = value;
                OnPropertyChanged("NextCommand");
            }
        }

        public string UrlSource {
            get { return urlSource; }
            set {
                if(urlSource == value)
                {
                    return;
                }
            
                urlSource = value;
                OnPropertyChanged("UrlSource");
            }
        }

        public void Back()
        {
            if(sourceIndex == 0)
            {
                UrlSource = $"https://lorempixel.com/1920/1080/sports/{sourceIndex}/";
            } 
            else
            {
                sourceIndex--;
                UrlSource = $"https://lorempixel.com/1920/1080/sports/{sourceIndex}/";
            }
        }

        public void Next()
        {
            if(sourceIndex == 10)
            {
                UrlSource = $"https://lorempixel.com/1920/1080/sports/{sourceIndex}/";
            } else
            {
                sourceIndex++;
                UrlSource = $"https://lorempixel.com/1920/1080/sports/{sourceIndex}/";
            }
        }

    }
}
