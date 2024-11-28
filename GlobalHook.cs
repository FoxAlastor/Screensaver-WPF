using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screensaver
{
    public static class GlobalHook
    {
        private static IKeyboardMouseEvents _globalHook;

        public static void InitializeGlobalHook()
        {
            _globalHook = Hook.GlobalEvents();

            _globalHook.KeyDown += TimerManager.OnUserActivity;
            _globalHook.MouseMove += TimerManager.OnUserActivity;
            _globalHook.MouseDown += TimerManager.OnUserActivity;
        }
        public static void CloseGlobalHook()
        {
            if (_globalHook != null)
            {
                _globalHook.KeyDown -= TimerManager.OnUserActivity;
                _globalHook.MouseMove -= TimerManager.OnUserActivity;
                _globalHook.MouseDown -= TimerManager.OnUserActivity;
                _globalHook.Dispose();
                _globalHook = null;
            }
        }
    }
}
