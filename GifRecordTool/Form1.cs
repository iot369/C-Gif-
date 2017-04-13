using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GIFRecorder;
/*
 * 名称：GIF屏幕录制demo
 * 作者：Crystal_lz
 * 时间：2016-03-18
 * 博客：var.la,clzf.co(最近关闭)
 * 简介：本来代码想全部自己写的 找了关于gif文件格式的资料还有lzw压缩算法
 * 可是发现这些还不够 不知道怎么建立颜色表 网上找了一下似乎都没有找到相关资料 估计也就只有一些图像处理的书籍里面才有了
 * 所以 代码并不是全部都是我写的 是网上下载的一个<AnimatedGifEncoder>来该的
 */
namespace GifRecordTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            pic_chose.Cursor = Cursors.Cross;
            pic_chose.MouseDown += (s, e) =>
            {
                if (m_frmRect == null) m_frmRect = new FrmHwnd();
                m_frmRect.Show();
            };
            pic_chose.MouseUp += (s, e) =>
            {
                if (m_frmRect != null)
                {
                    m_hWnd = m_frmRect.HWND;
                    label1.Text = m_hWnd.ToString("X").PadLeft(8, '0');
                    m_frmRect.Close();
                }
                m_frmRect = null;
            };
            lb_chose.Cursor = Cursors.Hand;
            lb_chose.Click += (s, e) =>
            {
                FrmRect frmRect = new FrmRect();
                frmRect.ShowDialog();
                m_rect = frmRect.Rect;
                lb_chose.Text = string.Format("{0},{1},{2},{3}", m_rect.X, m_rect.Y, m_rect.Width, m_rect.Height);
            };
        }

        private IntPtr m_hWnd;
        private Rectangle m_rect;
        private FrmHwnd m_frmRect;

        private ScreenRecorder m_scrRecorder;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_quality.SelectedIndex = 0;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "开始")
            {
                if (m_scrRecorder == null)
                {
                    if (rdbtn_hwnd.Checked && m_hWnd != IntPtr.Zero)
                    {
                        m_scrRecorder = new ScreenRecorder(m_hWnd, (int)nud_sleep.Value);
                    }
                    else if (rdbtn_rect.Checked && m_rect != Rectangle.Empty)
                    {
                        m_scrRecorder = new ScreenRecorder(m_rect, (int)nud_sleep.Value);
                    }
                    else
                    {
                        MessageBox.Show("确保对应的录制方式 有选择数据");
                        return;
                    }
                }
                m_scrRecorder.DrawCursor = chk_drawMouse.Checked;
                m_scrRecorder.Start();
                btn_start.Text = "停止";
                rdbtn_hwnd.Enabled = rdbtn_rect.Enabled = false;
                nud_sleep.Enabled = false;
                btn_reset.Enabled = btn_preview.Enabled = false;
                lb_chose.Enabled = pic_chose.Enabled = true;
            }
            else
            {
                m_scrRecorder.Stop();
                btn_start.Text = "开始";
                btn_reset.Enabled = btn_preview.Enabled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (m_scrRecorder != null) m_scrRecorder.Clear();
            m_scrRecorder = null;
            rdbtn_hwnd.Enabled = rdbtn_rect.Enabled = true;
            lb_chose.Enabled = pic_chose.Enabled = true;
            nud_sleep.Enabled = true;
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            Size sz = Size.Empty;
            foreach (var v in m_scrRecorder.Frames)
            {
                sz = v.Key.Size;
                break;
            }
            GIFCreator gc = new GIFCreator(sz.Width, sz.Height, cmb_quality.Text == "高" ? GIFCreator.GIFColorDepth.Depth8Bit : GIFCreator.GIFColorDepth.Depth4Bit);
            int i = 0;
            DateTime dt = DateTime.Now;
            foreach (var v in m_scrRecorder.Frames)
            {
                gc.AddFrame(v.Key, v.Value);
                label4.Text = "处理帧数据 -> " + (++i) + "/" + m_scrRecorder.Frames.Count + "[" + DateTime.Now.Subtract(dt).ToString() + "]";
                Application.DoEvents();
            }
            new FrmPre(gc.GetGifImage()).Show(this);
        }
    }
}
