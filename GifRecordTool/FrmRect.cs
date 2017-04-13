using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifRecordTool
{
    public partial class FrmRect : Form
    {
        public FrmRect() {
            InitializeComponent();
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            //this.TransparencyKey = this.BackColor;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private Rectangle _Rect;

        public Rectangle Rect {
            get { return _Rect; }
        }

        private Image m_img;
        private Image m_imgDark;
        private Point m_ptDown;

        protected override void OnLoad(EventArgs e) {
            Rectangle rect = Win32.GetDesktopRect();
            this.Location = rect.Location;
            this.Size = rect.Size;

            m_img = this.GetScreen();
            m_imgDark = new Bitmap(this.Width,this.Height);
            using (SolidBrush sb = new SolidBrush(Color.FromArgb(127, 0, 0, 0))) {
                using (Graphics g = Graphics.FromImage(m_imgDark)) {
                    g.DrawImage(m_img, 0, 0);
                    g.FillRectangle(sb, this.ClientRectangle);
                }
            }
            base.OnLoad(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            m_ptDown = e.Location;
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this._Rect.X = e.Location.X < m_ptDown.X ? e.Location.X : m_ptDown.X;
                this._Rect.Y = e.Location.Y < m_ptDown.Y ? e.Location.Y : m_ptDown.Y;
                this._Rect.Width = Math.Abs(e.Location.X - m_ptDown.X) + 1;
                this._Rect.Height = Math.Abs(e.Location.Y - m_ptDown.Y) + 1;
                this.Invalidate();
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) this.Close();
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            if (m_img != null) {
                g.DrawImage(m_imgDark, 0, 0);
                g.DrawImage(m_img, this._Rect, this._Rect, GraphicsUnit.Pixel);
                g.DrawRectangle(Pens.Cyan, this._Rect.X, this._Rect.Y, this._Rect.Width - 1, this._Rect.Height - 1);
            }
            base.OnPaint(e);
        }

        private Image GetScreen() {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp)) {
                g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            }
            return bmp;
        }
    }
}
