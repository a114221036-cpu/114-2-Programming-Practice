namespace WindowsFormsApp4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butChi
            // 
            this.butChi.Location = new System.Drawing.Point(259, 174);
            this.butChi.Name = "butChi";
            this.butChi.Size = new System.Drawing.Size(191, 98);
            this.butChi.TabIndex = 1;
            this.butChi.Text = "快樂";
            this.butChi.UseVisualStyleBackColor = true;
            this.butChi.Click += new System.EventHandler(this.butChi_Click);
            // 
            // btnEng
            // 
            this.btnEng.Location = new System.Drawing.Point(483, 174);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(191, 98);
            this.btnEng.TabIndex = 2;
            this.btnEng.Text = "Happy";
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.butChi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(337, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 103);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 92);
            this.button1.TabIndex = 4;
            this.button1.Text = "不爽";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.butChi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 98);
            this.button2.TabIndex = 5;
            this.button2.Text = "超不爽";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.butChi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 874);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

