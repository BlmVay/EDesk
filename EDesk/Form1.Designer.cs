﻿namespace EDesk
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.WBDesk = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WBDesk
            // 
            this.WBDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBDesk.Location = new System.Drawing.Point(0, 0);
            this.WBDesk.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBDesk.Name = "WBDesk";
            this.WBDesk.Size = new System.Drawing.Size(862, 388);
            this.WBDesk.TabIndex = 0;
            this.WBDesk.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 388);
            this.Controls.Add(this.WBDesk);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBDesk;
    }
}

