namespace GifRecordTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_sleep = new System.Windows.Forms.NumericUpDown();
            this.chk_drawMouse = new System.Windows.Forms.CheckBox();
            this.cmb_quality = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_hwnd = new System.Windows.Forms.RadioButton();
            this.rdbtn_rect = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_chose = new System.Windows.Forms.Label();
            this.pic_chose = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sleep)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "拖动选择窗体";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "间隔:";
            // 
            // nud_sleep
            // 
            this.nud_sleep.Location = new System.Drawing.Point(42, 77);
            this.nud_sleep.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_sleep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_sleep.Name = "nud_sleep";
            this.nud_sleep.Size = new System.Drawing.Size(108, 20);
            this.nud_sleep.TabIndex = 7;
            this.nud_sleep.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // chk_drawMouse
            // 
            this.chk_drawMouse.AutoSize = true;
            this.chk_drawMouse.Checked = true;
            this.chk_drawMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_drawMouse.Location = new System.Drawing.Point(42, 103);
            this.chk_drawMouse.Name = "chk_drawMouse";
            this.chk_drawMouse.Size = new System.Drawing.Size(98, 17);
            this.chk_drawMouse.TabIndex = 8;
            this.chk_drawMouse.Text = "绘制鼠标位置";
            this.chk_drawMouse.UseVisualStyleBackColor = true;
            // 
            // cmb_quality
            // 
            this.cmb_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quality.FormattingEnabled = true;
            this.cmb_quality.Items.AddRange(new object[] {
            "高",
            "低"});
            this.cmb_quality.Location = new System.Drawing.Point(54, 151);
            this.cmb_quality.Name = "cmb_quality";
            this.cmb_quality.Size = new System.Drawing.Size(108, 21);
            this.cmb_quality.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "质量:";
            // 
            // rdbtn_hwnd
            // 
            this.rdbtn_hwnd.AutoSize = true;
            this.rdbtn_hwnd.Checked = true;
            this.rdbtn_hwnd.Location = new System.Drawing.Point(22, 25);
            this.rdbtn_hwnd.Name = "rdbtn_hwnd";
            this.rdbtn_hwnd.Size = new System.Drawing.Size(14, 13);
            this.rdbtn_hwnd.TabIndex = 11;
            this.rdbtn_hwnd.TabStop = true;
            this.rdbtn_hwnd.UseVisualStyleBackColor = true;
            // 
            // rdbtn_rect
            // 
            this.rdbtn_rect.AutoSize = true;
            this.rdbtn_rect.Location = new System.Drawing.Point(22, 53);
            this.rdbtn_rect.Name = "rdbtn_rect";
            this.rdbtn_rect.Size = new System.Drawing.Size(14, 13);
            this.rdbtn_rect.TabIndex = 12;
            this.rdbtn_rect.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(187, 26);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 78);
            this.btn_start.TabIndex = 13;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(187, 149);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(94, 23);
            this.btn_preview.TabIndex = 14;
            this.btn_preview.Text = "预览";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_chose);
            this.groupBox1.Controls.Add(this.pic_chose);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbtn_rect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbtn_hwnd);
            this.groupBox1.Controls.Add(this.nud_sleep);
            this.groupBox1.Controls.Add(this.chk_drawMouse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 131);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(187, 120);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 23);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "重置帧";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_chose
            // 
            this.lb_chose.AutoSize = true;
            this.lb_chose.Location = new System.Drawing.Point(42, 52);
            this.lb_chose.Name = "lb_chose";
            this.lb_chose.Size = new System.Drawing.Size(109, 13);
            this.lb_chose.TabIndex = 17;
            this.lb_chose.Text = "选择区域(右键确定)";
            // 
            // pic_chose
            // 
            this.pic_chose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_chose.Image = global::GifRecordTool.Properties.Resources.spy;
            this.pic_chose.Location = new System.Drawing.Point(42, 19);
            this.pic_chose.Name = "pic_chose";
            this.pic_chose.Size = new System.Drawing.Size(23, 23);
            this.pic_chose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_chose.TabIndex = 3;
            this.pic_chose.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "::::::";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 197);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_quality);
            this.Name = "Form1";
            this.Text = "GIF录制工具 by Crystal_lz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_sleep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_chose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_sleep;
        private System.Windows.Forms.CheckBox chk_drawMouse;
        private System.Windows.Forms.ComboBox cmb_quality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtn_hwnd;
        private System.Windows.Forms.RadioButton rdbtn_rect;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lb_chose;
        private System.Windows.Forms.Label label4;
    }
}

