namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cBox_Pen = new System.Windows.Forms.ComboBox();
            this.label_PensColor = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.cBox_n = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label_th2Show = new System.Windows.Forms.Label();
            this.label_th1Show = new System.Windows.Forms.Label();
            this.label_per2Show = new System.Windows.Forms.Label();
            this.label_per1Show = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label_lengShow = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_leng = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBox_Pen
            // 
            this.cBox_Pen.Font = new System.Drawing.Font("宋体", 12F);
            this.cBox_Pen.FormattingEnabled = true;
            this.cBox_Pen.Items.AddRange(new object[] {
            "红色",
            "橙色",
            "黄色",
            "绿色",
            "青色",
            "蓝色",
            "紫色",
            "黑色"});
            this.cBox_Pen.Location = new System.Drawing.Point(117, 54);
            this.cBox_Pen.Name = "cBox_Pen";
            this.cBox_Pen.Size = new System.Drawing.Size(89, 28);
            this.cBox_Pen.TabIndex = 1;
            this.cBox_Pen.Text = "蓝色";
            this.cBox_Pen.SelectedIndexChanged += new System.EventHandler(this.cob_Pen_SelectedIndexChanged);
            // 
            // label_PensColor
            // 
            this.label_PensColor.AutoSize = true;
            this.label_PensColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_PensColor.Font = new System.Drawing.Font("宋体", 12F);
            this.label_PensColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_PensColor.Location = new System.Drawing.Point(20, 55);
            this.label_PensColor.Name = "label_PensColor";
            this.label_PensColor.Size = new System.Drawing.Size(91, 22);
            this.label_PensColor.TabIndex = 2;
            this.label_PensColor.Text = "画笔颜色";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_n.Font = new System.Drawing.Font("宋体", 12F);
            this.label_n.Location = new System.Drawing.Point(20, 17);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(91, 22);
            this.label_n.TabIndex = 3;
            this.label_n.Text = "递归深度";
            // 
            // cBox_n
            // 
            this.cBox_n.Font = new System.Drawing.Font("宋体", 12F);
            this.cBox_n.FormattingEnabled = true;
            this.cBox_n.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13"});
            this.cBox_n.Location = new System.Drawing.Point(117, 15);
            this.cBox_n.Name = "cBox_n";
            this.cBox_n.Size = new System.Drawing.Size(89, 28);
            this.cBox_n.TabIndex = 4;
            this.cBox_n.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.trackBar5);
            this.panel1.Controls.Add(this.trackBar4);
            this.panel1.Controls.Add(this.label_th2Show);
            this.panel1.Controls.Add(this.label_th1Show);
            this.panel1.Controls.Add(this.label_per2Show);
            this.panel1.Controls.Add(this.label_per1Show);
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label_lengShow);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_leng);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label_n);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cBox_n);
            this.panel1.Controls.Add(this.cBox_Pen);
            this.panel1.Controls.Add(this.label_PensColor);
            this.panel1.Location = new System.Drawing.Point(503, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 491);
            this.panel1.TabIndex = 5;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(137, 371);
            this.trackBar5.Maximum = 180;
            this.trackBar5.Minimum = 1;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(182, 56);
            this.trackBar5.TabIndex = 23;
            this.trackBar5.Value = 20;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(137, 298);
            this.trackBar4.Maximum = 180;
            this.trackBar4.Minimum = 1;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(182, 56);
            this.trackBar4.TabIndex = 22;
            this.trackBar4.Value = 30;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // label_th2Show
            // 
            this.label_th2Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_th2Show.Font = new System.Drawing.Font("宋体", 12F);
            this.label_th2Show.Location = new System.Drawing.Point(20, 402);
            this.label_th2Show.Name = "label_th2Show";
            this.label_th2Show.Size = new System.Drawing.Size(76, 25);
            this.label_th2Show.TabIndex = 21;
            this.label_th2Show.Text = "0.3490";
            this.label_th2Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_th1Show
            // 
            this.label_th1Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_th1Show.Font = new System.Drawing.Font("宋体", 12F);
            this.label_th1Show.Location = new System.Drawing.Point(20, 329);
            this.label_th1Show.Name = "label_th1Show";
            this.label_th1Show.Size = new System.Drawing.Size(76, 25);
            this.label_th1Show.TabIndex = 20;
            this.label_th1Show.Text = "0.5235";
            this.label_th1Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_per2Show
            // 
            this.label_per2Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_per2Show.Font = new System.Drawing.Font("宋体", 12F);
            this.label_per2Show.Location = new System.Drawing.Point(20, 257);
            this.label_per2Show.Name = "label_per2Show";
            this.label_per2Show.Size = new System.Drawing.Size(76, 25);
            this.label_per2Show.TabIndex = 17;
            this.label_per2Show.Text = "0.7";
            this.label_per2Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_per1Show
            // 
            this.label_per1Show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_per1Show.Font = new System.Drawing.Font("宋体", 12F);
            this.label_per1Show.Location = new System.Drawing.Point(20, 188);
            this.label_per1Show.Name = "label_per1Show";
            this.label_per1Show.Size = new System.Drawing.Size(76, 25);
            this.label_per1Show.TabIndex = 16;
            this.label_per1Show.Text = "0.6";
            this.label_per1Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(157, 226);
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(182, 56);
            this.trackBar3.TabIndex = 15;
            this.trackBar3.Value = 7;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(157, 157);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(182, 56);
            this.trackBar2.TabIndex = 14;
            this.trackBar2.Value = 6;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // label_lengShow
            // 
            this.label_lengShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_lengShow.Font = new System.Drawing.Font("宋体", 12F);
            this.label_lengShow.Location = new System.Drawing.Point(20, 120);
            this.label_lengShow.Name = "label_lengShow";
            this.label_lengShow.Size = new System.Drawing.Size(76, 25);
            this.label_lengShow.TabIndex = 13;
            this.label_lengShow.Text = "100";
            this.label_lengShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(20, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "左分支角度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(20, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "右分支角度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(20, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "左分支长度比";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(20, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "右分支长度比";
            // 
            // label_leng
            // 
            this.label_leng.AutoSize = true;
            this.label_leng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_leng.Font = new System.Drawing.Font("宋体", 12F);
            this.label_leng.Location = new System.Drawing.Point(20, 89);
            this.label_leng.Name = "label_leng";
            this.label_leng.Size = new System.Drawing.Size(91, 22);
            this.label_leng.TabIndex = 6;
            this.label_leng.Text = "主干长度";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(117, 89);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(222, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // drawPanel
            // 
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(35, 12);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(441, 491);
            this.drawPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 515);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cBox_Pen;
        private System.Windows.Forms.Label label_PensColor;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.ComboBox cBox_n;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_leng;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_lengShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_per2Show;
        private System.Windows.Forms.Label label_per1Show;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label_th2Show;
        private System.Windows.Forms.Label label_th1Show;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Panel drawPanel;
    }
}

