namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butChi = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butChi
            // 
            this.butChi.Location = new System.Drawing.Point(247, 113);
            this.butChi.Name = "butChi";
            this.butChi.Size = new System.Drawing.Size(191, 98);
            this.butChi.TabIndex = 0;
            this.butChi.Text = "快樂";
            this.butChi.UseVisualStyleBackColor = true;
            this.butChi.Click += new System.EventHandler(this.butChi_Click);
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(476, 113);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(191, 98);
            this.btnEng.TabIndex = 1;
            this.btnEng.Text = "Happy";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.butChi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(304, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 129);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.butChi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butChi;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Label label1;
    }
}

