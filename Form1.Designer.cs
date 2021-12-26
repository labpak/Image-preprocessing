namespace VKR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenImageButton = new System.Windows.Forms.Button();
            this.OriginalImage = new System.Windows.Forms.PictureBox();
            this.PreparationButton = new System.Windows.Forms.Button();
            this.ZhangCheckBox = new System.Windows.Forms.CheckBox();
            this.AforgeCheckBox = new System.Windows.Forms.CheckBox();
            this.EmguCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ResImage
            // 
            this.ResImage.Location = new System.Drawing.Point(596, 12);
            this.ResImage.Name = "ResImage";
            this.ResImage.Size = new System.Drawing.Size(584, 516);
            this.ResImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResImage.TabIndex = 2;
            this.ResImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(873, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result Image";
            // 
            // OpenImageButton
            // 
            this.OpenImageButton.Location = new System.Drawing.Point(1201, 12);
            this.OpenImageButton.Name = "OpenImageButton";
            this.OpenImageButton.Size = new System.Drawing.Size(126, 23);
            this.OpenImageButton.TabIndex = 5;
            this.OpenImageButton.Text = "Open Image";
            this.OpenImageButton.UseVisualStyleBackColor = true;
            this.OpenImageButton.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // OriginalImage
            // 
            this.OriginalImage.Location = new System.Drawing.Point(6, 12);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(584, 516);
            this.OriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalImage.TabIndex = 6;
            this.OriginalImage.TabStop = false;
            // 
            // PreparationButton
            // 
            this.PreparationButton.Location = new System.Drawing.Point(1201, 136);
            this.PreparationButton.Name = "PreparationButton";
            this.PreparationButton.Size = new System.Drawing.Size(126, 23);
            this.PreparationButton.TabIndex = 7;
            this.PreparationButton.Text = "Process Image";
            this.PreparationButton.UseVisualStyleBackColor = true;
            this.PreparationButton.Click += new System.EventHandler(this.PreparationButton_Click);
            // 
            // ZhangCheckBox
            // 
            this.ZhangCheckBox.AutoSize = true;
            this.ZhangCheckBox.Location = new System.Drawing.Point(1201, 67);
            this.ZhangCheckBox.Name = "ZhangCheckBox";
            this.ZhangCheckBox.Size = new System.Drawing.Size(82, 17);
            this.ZhangCheckBox.TabIndex = 8;
            this.ZhangCheckBox.Text = "ZhangSuen";
            this.ZhangCheckBox.UseVisualStyleBackColor = true;
            this.ZhangCheckBox.CheckedChanged += new System.EventHandler(this.ZhangCheckBox_CheckedChanged);
            // 
            // AforgeCheckBox
            // 
            this.AforgeCheckBox.AutoSize = true;
            this.AforgeCheckBox.Location = new System.Drawing.Point(1201, 90);
            this.AforgeCheckBox.Name = "AforgeCheckBox";
            this.AforgeCheckBox.Size = new System.Drawing.Size(57, 17);
            this.AforgeCheckBox.TabIndex = 9;
            this.AforgeCheckBox.Text = "Aforge";
            this.AforgeCheckBox.UseVisualStyleBackColor = true;
            this.AforgeCheckBox.CheckedChanged += new System.EventHandler(this.AforgeCheckBox_CheckedChanged);
            // 
            // EmguCheckBox
            // 
            this.EmguCheckBox.AutoSize = true;
            this.EmguCheckBox.Location = new System.Drawing.Point(1201, 113);
            this.EmguCheckBox.Name = "EmguCheckBox";
            this.EmguCheckBox.Size = new System.Drawing.Size(53, 17);
            this.EmguCheckBox.TabIndex = 10;
            this.EmguCheckBox.Text = "Emgu";
            this.EmguCheckBox.UseVisualStyleBackColor = true;
            this.EmguCheckBox.CheckedChanged += new System.EventHandler(this.EmguCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1198, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select the type of skeleton";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(1201, 165);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(126, 23);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 547);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmguCheckBox);
            this.Controls.Add(this.AforgeCheckBox);
            this.Controls.Add(this.ZhangCheckBox);
            this.Controls.Add(this.PreparationButton);
            this.Controls.Add(this.OriginalImage);
            this.Controls.Add(this.OpenImageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ResImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OpenImageButton;
        private System.Windows.Forms.PictureBox OriginalImage;
        private System.Windows.Forms.Button PreparationButton;
        private System.Windows.Forms.CheckBox ZhangCheckBox;
        private System.Windows.Forms.CheckBox AforgeCheckBox;
        private System.Windows.Forms.CheckBox EmguCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
    }
}

