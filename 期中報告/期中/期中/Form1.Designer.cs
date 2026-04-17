namespace 期中
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
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(126, 71);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(84, 38);
            this.hoursWorkedPromptLabel.TabIndex = 19;
            this.hoursWorkedPromptLabel.Text = "工時:";
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("新細明體", 22F);
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(216, 71);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(282, 43);
            this.hoursWorkedTextBox.TabIndex = 21;
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(126, 135);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(84, 38);
            this.hourlyPayRatePromptLabel.TabIndex = 22;
            this.hourlyPayRatePromptLabel.Text = "時薪:";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Font = new System.Drawing.Font("新細明體", 22F);
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(216, 130);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(282, 43);
            this.hourlyPayRateTextBox.TabIndex = 23;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(96, 198);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(114, 38);
            this.outputDescriptionLabel.TabIndex = 24;
            this.outputDescriptionLabel.Text = "總薪資:";
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Font = new System.Drawing.Font("新細明體", 22F);
            this.grossPayLabel.Location = new System.Drawing.Point(217, 198);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(281, 41);
            this.grossPayLabel.TabIndex = 25;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(73, 260);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(183, 77);
            this.calculateButton.TabIndex = 26;
            this.calculateButton.Text = "計算總薪資";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(281, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(121, 77);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(433, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 77);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label hoursWorkedPromptLabel;
        internal System.Windows.Forms.TextBox hoursWorkedTextBox;
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel;
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox;
        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button exitButton;
    }
}

