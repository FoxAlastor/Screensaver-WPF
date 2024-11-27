using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            TimerManager.InitializeTimer(IntervalValue);
            GlobalHook.InitializeGlobalHook();
        }
        public ICommand PreviewScreenС { get; set; }
        private void PreviewScreen(object obj)
        {
            TimerManager.StopTimer();
            GlobalHook.CloseGlobalHook();
            App.StartScreenSaverWindow();


            GlobalHook.InitializeGlobalHook();

        }

        private int _intervalValue = 1;
        public int IntervalValue
        {
            get => _intervalValue;
            set
            {
                _intervalValue = value;
                TimerManager.Interval = value;
                OnPropertyChanged();
            }
        }
    }
}
