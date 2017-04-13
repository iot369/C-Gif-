using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifRecordTool
{
    public partial class FrmHwnd : Form
    {
        public FrmHwnd() {
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;
        }

        private IntPtr _hWnd;

        public IntPtr HWND {
            get { return _hWnd; }
        }
        private Rectangle m_rect;

        protected override void OnLoad(EventArgs e) {
            Rectangle rect = Win32.GetDesktopRect();
            this.Location = rect.Location;
            this.Size = rect.Size;
            this.timer1.Interval = 100;
            this.timer1.Start();
            base.OnLoad(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            using (Pen p = new Pen(Color.Cyan, 3)) {
                e.Graphics.DrawRectangle(p, m_rect.X, m_rect.Y, m_rect.Width - 1, m_rect.Height - 1);
            }
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.TopMost = true;
            Win32.RECT rect = new Win32.RECT();
            IntPtr hWnd = Win32.WindowFromPoint(MousePosition);
            if (this._hWnd == hWnd) return;
            this._hWnd = hWnd;
            Win32.GetWindowRect(_hWnd, ref rect);
            m_rect = rect.ToRectangle();
            this.Invalidate();
        }
    }
}
