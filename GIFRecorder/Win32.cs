using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.InteropServices;

namespace GIFRecorder
{
    internal class Win32
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        public struct POINT {
            public int X;
            public int Y;
        }

        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public System.Drawing.Rectangle ToRectangle() {
                return new System.Drawing.Rectangle(this.Left, this.Top, this.Right - this.Left + 1, this.Bottom - this.Top + 1);
            }
        }
    }
}
