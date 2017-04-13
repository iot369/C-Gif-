using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GifRecordTool
{
    public partial class FrmPre : Form
    {
        public FrmPre(Image img)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            pictureBox1.Image = img;
            ClientSize = img.Size;
        }

        protected override void OnLoad(EventArgs e) {
            this.CenterToParent();
            base.OnLoad(e);
        }

        private void 保存图像ToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.gif|*.gif";
            if (sfd.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image.Save(sfd.FileName);
            }
        }
    }
}
