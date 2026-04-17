namespace Tutorial_2_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardfacePictureBox = new PictureBox();
            cardbackPictureBox = new PictureBox();
            showfaceButton = new Button();
            showbackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardfacePictureBox
            // 
            cardfacePictureBox.Image = Properties.Resources.Ace_Hearts;
            cardfacePictureBox.Location = new Point(63, 24);
            cardfacePictureBox.Name = "cardfacePictureBox";
            cardfacePictureBox.Size = new Size(320, 339);
            cardfacePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardfacePictureBox.TabIndex = 0;
            cardfacePictureBox.TabStop = false;
            cardfacePictureBox.Click += cardfacePictureBox_Click;
            // 
            // cardbackPictureBox
            // 
            cardbackPictureBox.Image = Properties.Resources.Backface_Red;
            cardbackPictureBox.Location = new Point(430, 24);
            cardbackPictureBox.Name = "cardbackPictureBox";
            cardbackPictureBox.Size = new Size(314, 339);
            cardbackPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardbackPictureBox.TabIndex = 1;
            cardbackPictureBox.TabStop = false;
            // 
            // showfaceButton
            // 
            showfaceButton.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showfaceButton.Location = new Point(85, 401);
            showfaceButton.Name = "showfaceButton";
            showfaceButton.Size = new Size(298, 88);
            showfaceButton.TabIndex = 2;
            showfaceButton.Text = "顯示正面";
            showfaceButton.UseVisualStyleBackColor = true;
            showfaceButton.Click += showfaceButton_Click;
            // 
            // showbackButton
            // 
            showbackButton.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showbackButton.Location = new Point(446, 401);
            showbackButton.Name = "showbackButton";
            showbackButton.Size = new Size(298, 88);
            showbackButton.TabIndex = 3;
            showbackButton.Text = "顯示背面";
            showbackButton.UseVisualStyleBackColor = true;
            showbackButton.Click += showbackButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 601);
            Controls.Add(showbackButton);
            Controls.Add(showfaceButton);
            Controls.Add(cardbackPictureBox);
            Controls.Add(cardfacePictureBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardfacePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardbackPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardfacePictureBox;
        private PictureBox cardbackPictureBox;
        private Button showfaceButton;
        private Button showbackButton;
    }
}
