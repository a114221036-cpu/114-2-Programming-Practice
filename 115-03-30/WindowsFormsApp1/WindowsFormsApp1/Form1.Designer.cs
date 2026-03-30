namespace WindowsFormsApp1
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl1.Location = new System.Drawing.Point(183, 150);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(571, 101);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "label1";
            this.Lbl1.Click += new System.EventHandler(this.LblMsg_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl2.Location = new System.Drawing.Point(183, 295);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(571, 102);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Lbl2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 1040);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
    }
}

