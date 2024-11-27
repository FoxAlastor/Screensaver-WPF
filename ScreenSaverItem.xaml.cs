using Hurricane.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Screensaver
{
    /// <summary>
    /// Логика взаимодействия для ScreenSaverItem.xaml
    /// </summary>
    public partial class ScreenSaverItem : System.Windows.Window
    {
        public ScreenSaverItem(WpfScreen screen)
        {
            InitializeComponent();

            this.Width = screen.DeviceBounds.Width;
            this.Height = screen.DeviceBounds.Height;

            this.Left = screen.DeviceBounds.X;
            this.Top = screen.DeviceBounds.Y;

        }
    }
}
