using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;
using System.Runtime.InteropServices;

namespace GifRecordTool
{
    internal class Win32
    {
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int nIndex);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point lpPoint);

        public const int SM_XVIRTUALSCREEN = 76;
        public const int SM_YVIRTUALSCREEN = 77;
        public const int SM_CXVIRTUALSCREEN = 78;
        public const int SM_CYVIRTUALSCREEN = 79;

        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public System.Drawing.Rectangle ToRectangle() {
                return new System.Drawing.Rectangle(this.Left, this.Top, this.Right - this.Left, this.Bottom - this.Top);
            }
        }

        public static Rectangle GetDesktopRect() {
            Rectangle rect = new Rectangle();
            rect.X = Win32.GetSystemMetrics(Win32.SM_XVIRTUALSCREEN);
            rect.Y = Win32.GetSystemMetrics(Win32.SM_YVIRTUALSCREEN);
            rect.Width = Win32.GetSystemMetrics(Win32.SM_CXVIRTUALSCREEN);
            rect.Height = Win32.GetSystemMetrics(Win32.SM_CYVIRTUALSCREEN);
            return rect;
        }
    }
}
