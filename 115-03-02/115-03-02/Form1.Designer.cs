using System;

namespace _115_03_02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.LblMsg = new System.Windows.Forms.Label();
            this.ImgDice = new System.Windows.Forms.ImageList(this.components);
            this.TmrGo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgCoin = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(233, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "擲骰子遊戲";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStart.Location = new System.Drawing.Point(183, 348);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(124, 54);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "開始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnStop.Location = new System.Drawing.Point(405, 348);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(124, 54);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "停止";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click_1);
            // 
            // Pic1
            // 
            this.Pic1.Location = new System.Drawing.Point(195, 157);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(56, 56);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic1.TabIndex = 4;
            this.Pic1.TabStop = false;
            this.Pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // Pic2
            // 
            this.Pic2.Location = new System.Drawing.Point(312, 157);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(56, 56);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic2.TabIndex = 5;
            this.Pic2.TabStop = false;
            // 
            // Pic3
            // 
            this.Pic3.Location = new System.Drawing.Point(431, 157);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(56, 56);
            this.Pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic3.TabIndex = 6;
            this.Pic3.TabStop = false;
            // 
            // LblMsg
            // 
            this.LblMsg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblMsg.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LblMsg.Location = new System.Drawing.Point(150, 256);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(407, 60);
            this.LblMsg.TabIndex = 7;
            this.LblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgDice
            // 
            this.ImgDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgDice.ImageStream")));
            this.ImgDice.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgDice.Images.SetKeyName(0, "d1(2).jpg");
            this.ImgDice.Images.SetKeyName(1, "d2(2).jpg");
            this.ImgDice.Images.SetKeyName(2, "d3(2).jpg");
            this.ImgDice.Images.SetKeyName(3, "d4(2).jpg");
            this.ImgDice.Images.SetKeyName(4, "d5(2).jpg");
            this.ImgDice.Images.SetKeyName(5, "d6(2).jpg");
            // 
            // TmrGo
            // 
            this.TmrGo.Tick += new System.EventHandler(this.TmrGo_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(638, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(638, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // imgCoin
            // 
            this.imgCoin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCoin.ImageStream")));
            this.imgCoin.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCoin.Images.SetKeyName(0, "Heads.bmp");
            this.imgCoin.Images.SetKeyName(1, "Tails.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblMsg);
            this.Controls.Add(this.Pic3);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "擲骰子遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.PictureBox Pic3;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.ImageList ImgDice;
        private System.Windows.Forms.Timer TmrGo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imgCoin;
    }
}

