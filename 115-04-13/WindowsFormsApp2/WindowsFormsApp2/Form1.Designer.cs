namespace WindowsFormsApp2
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
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PicPc = new System.Windows.Forms.PictureBox();
            this.LblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPc)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(214, 210);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(105, 105);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "button1";
            this.Btn1.UseVisualStyleBackColor = true;
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(372, 210);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(105, 105);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "button2";
            this.Btn2.UseVisualStyleBackColor = true;
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(542, 210);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(105, 105);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "button3";
            this.Btn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "電腦出拳:";
            // 
            // PicPc
            // 
            this.PicPc.Location = new System.Drawing.Point(372, 334);
            this.PicPc.Name = "PicPc";
            this.PicPc.Size = new System.Drawing.Size(105, 105);
            this.PicPc.TabIndex = 6;
            this.PicPc.TabStop = false;
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblMsg.Location = new System.Drawing.Point(499, 397);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(148, 42);
            this.LblMsg.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 605);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.PicPc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PicPc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicPc;
        private System.Windows.Forms.Label LblMsg;
    }
}

