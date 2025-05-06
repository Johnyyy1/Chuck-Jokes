using System.Windows.Forms;

namespace Chuck_Jokes
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(432, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(357, 201);
            label1.Name = "label1";
            label1.Size = new Size(350, 54);
            label1.TabIndex = 1;
            label1.Text = "Chuck Norris Facts";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 222, 220);
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(443, 258);
            button1.Name = "button1";
            button1.Size = new Size(174, 50);
            button1.TabIndex = 2;
            button1.Text = "Get Fact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 354);
            label2.Name = "label2";
            label2.Size = new Size(285, 28);
            label2.TabIndex = 3;
            label2.Text = "YOUR FACT WILL APPEAR HERE";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 100, 100);
            ClientSize = new Size(1042, 529);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}
