namespace CrawlApp
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
            this.startBtn = new System.Windows.Forms.Button();
            this.StartUrlText = new System.Windows.Forms.TextBox();
            this.MsgListBox = new System.Windows.Forms.ListBox();
            this.NumberText = new System.Windows.Forms.TextBox();
            this.endBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(651, 12);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // StartUrlText
            // 
            this.StartUrlText.Location = new System.Drawing.Point(88, 12);
            this.StartUrlText.Name = "StartUrlText";
            this.StartUrlText.Size = new System.Drawing.Size(375, 25);
            this.StartUrlText.TabIndex = 1;
            this.StartUrlText.Text = "https://www.liaoxuefeng.com/";
            // 
            // MsgListBox
            // 
            this.MsgListBox.FormattingEnabled = true;
            this.MsgListBox.ItemHeight = 15;
            this.MsgListBox.Location = new System.Drawing.Point(12, 43);
            this.MsgListBox.Name = "MsgListBox";
            this.MsgListBox.Size = new System.Drawing.Size(714, 559);
            this.MsgListBox.TabIndex = 5;
            // 
            // NumberText
            // 
            this.NumberText.Location = new System.Drawing.Point(571, 12);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(74, 25);
            this.NumberText.TabIndex = 6;
            this.NumberText.Text = "10";
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(651, 611);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(75, 23);
            this.endBtn.TabIndex = 7;
            this.endBtn.Text = "结束";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "输入网站";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(495, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "输入次数";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.MsgListBox);
            this.Controls.Add(this.StartUrlText);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox StartUrlText;
        private System.Windows.Forms.ListBox MsgListBox;
        private System.Windows.Forms.TextBox NumberText;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

