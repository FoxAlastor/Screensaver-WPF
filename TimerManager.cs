
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Screensaver
{
    public static class TimerManager
    {
        private static DispatcherTimer _timer;

        private static DateTime _lastActivityTime;

        private static int _interval;
        public static int Interval
        {
            get => _interval;
            set
            {
                _interval = value;
            }
        }
        public static void InitializeTimer(int interval)
        {
            _interval = interval;

            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _timer.Tick += OnTimerTick;
            _timer.Start();

            _lastActivityTime = DateTime.Now;
        }

        public static void OnUserActivity(object sender, EventArgs e)
        {
            _lastActivityTime = DateTime.Now;
            if (App.ScreenSaverBeenOn)
            {
                App.CloseScreenSaverWindow();
                _timer.Start();
            }
        }

        private static void OnTimerTick(object sender, EventArgs e)
        {
            if ((DateTime.Now - _lastActivityTime).TotalSeconds >= _interval * 60)
            {
                _timer.Stop();
                App.StartScreenSaverWindow();
            }
        }
        public static void StopTimer()
        {
            _timer?.Stop();
        }
    }
}
