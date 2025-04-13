namespace PrzetwarzanieObrazow
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
            original = new PictureBox();
            negative = new PictureBox();
            greyscale = new PictureBox();
            mirror = new PictureBox();
            threshold = new PictureBox();
            LoadImageButton = new Button();
            RunButton = new Button();
            ((System.ComponentModel.ISupportInitialize)original).BeginInit();
            ((System.ComponentModel.ISupportInitialize)negative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greyscale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mirror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)threshold).BeginInit();
            SuspendLayout();
            // 
            // original
            // 
            original.Location = new Point(40, 32);
            original.Name = "original";
            original.Size = new Size(205, 205);
            original.SizeMode = PictureBoxSizeMode.Zoom;
            original.TabIndex = 0;
            original.TabStop = false;
            original.WaitOnLoad = true;
            // 
            // negative
            // 
            negative.Location = new Point(334, 32);
            negative.Name = "negative";
            negative.Size = new Size(205, 205);
            negative.SizeMode = PictureBoxSizeMode.Zoom;
            negative.TabIndex = 1;
            negative.TabStop = false;
            negative.WaitOnLoad = true;
            // 
            // greyscale
            // 
            greyscale.Location = new Point(334, 293);
            greyscale.Name = "greyscale";
            greyscale.Size = new Size(205, 205);
            greyscale.SizeMode = PictureBoxSizeMode.Zoom;
            greyscale.TabIndex = 2;
            greyscale.TabStop = false;
            greyscale.WaitOnLoad = true;
            // 
            // mirror
            // 
            mirror.Location = new Point(604, 32);
            mirror.Name = "mirror";
            mirror.Size = new Size(205, 205);
            mirror.SizeMode = PictureBoxSizeMode.Zoom;
            mirror.TabIndex = 3;
            mirror.TabStop = false;
            mirror.WaitOnLoad = true;
            // 
            // threshold
            // 
            threshold.Location = new Point(604, 293);
            threshold.Name = "threshold";
            threshold.Size = new Size(205, 205);
            threshold.SizeMode = PictureBoxSizeMode.Zoom;
            threshold.TabIndex = 4;
            threshold.TabStop = false;
            threshold.WaitOnLoad = true;
            // 
            // LoadImageButton
            // 
            LoadImageButton.Location = new Point(80, 309);
            LoadImageButton.Name = "LoadImageButton";
            LoadImageButton.Size = new Size(118, 59);
            LoadImageButton.TabIndex = 5;
            LoadImageButton.Text = "load image";
            LoadImageButton.UseVisualStyleBackColor = true;
            LoadImageButton.Click += LoadImageButton_Click;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(80, 418);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(118, 59);
            RunButton.TabIndex = 6;
            RunButton.Text = "run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 539);
            Controls.Add(RunButton);
            Controls.Add(LoadImageButton);
            Controls.Add(threshold);
            Controls.Add(mirror);
            Controls.Add(greyscale);
            Controls.Add(negative);
            Controls.Add(original);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)original).EndInit();
            ((System.ComponentModel.ISupportInitialize)negative).EndInit();
            ((System.ComponentModel.ISupportInitialize)greyscale).EndInit();
            ((System.ComponentModel.ISupportInitialize)mirror).EndInit();
            ((System.ComponentModel.ISupportInitialize)threshold).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox original;
        private PictureBox negative;
        private PictureBox greyscale;
        private PictureBox mirror;
        private PictureBox threshold;
        private Button LoadImageButton;
        private Button RunButton;
    }
}
