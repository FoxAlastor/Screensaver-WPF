using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using Hurricane.Utilities;
using System.Windows.Forms;
using System.ComponentModel;
using System.Windows.Threading;

namespace Screensaver
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>

    public partial class App : System.Windows.Application
    {
        public static ScreenSaverItem[] WindowItems;
        public ScreenSaverItem[] _windowItems
        {
            get => _windowItems;
            set
            {
                _windowItems = value;
            }
        }

        public static WpfScreen[] allScreens;
        public WpfScreen[] _allScreens
        {
            get => _allScreens;
            set
            {
                _allScreens = value;
            }
        }

        public static bool ScreenSaverBeenOn = false;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            allScreens = WpfScreen.AllScreens().ToArray();
            WindowItems = new ScreenSaverItem[allScreens.Length];

            for (int i = 0; i < WindowItems.Length; i++)
            {
                WindowItems[i] = new ScreenSaverItem(allScreens[i]);
            }

        }

        public static void CloseScreenSaverWindow()
        {
            foreach (ScreenSaverItem item in WindowItems) { item.Hide(); }
            ScreenSaverBeenOn = false;
        }

        public static void StartScreenSaverWindow()
        {
            foreach (ScreenSaverItem item in WindowItems) { item.Show(); }
            ScreenSaverBeenOn = true;
        }
    }
}
