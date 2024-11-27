using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Screensaver
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            PreviewScreenС = new RelayCommand(PreviewScreen);


        }

        private void PreviewScreen(object obj)
        {



        }

        public ICommand PreviewScreenС { get; set; }


        private int _changeScreenSaverComBox;

        public int ChangeScreenSaverComBox
        {
            get => _changeScreenSaverComBox;
            set
            {
                _changeScreenSaverComBox = value;
                OnPropertyChanged();
            }
        }


        private int _changeIntervalScrollBar;

        public int ChangeIntervalScrollBar
        {
            get => _changeIntervalScrollBar;
            set
            {
                _changeIntervalScrollBar = value;
                OnPropertyChanged();
            }
        }

        private int _intervalTextBox;

        public int IntervalTextBox
        {
            get => _intervalTextBox;
            set
            {
                _intervalTextBox = value;
                OnPropertyChanged();
            }
        }










    }
}
