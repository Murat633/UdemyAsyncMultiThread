namespace TaskThreadApp
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
            btnStart = new Button();
            prgrssBar1 = new ProgressBar();
            prgrssBar2 = new ProgressBar();
            btnCounter = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(200, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // prgrssBar1
            // 
            prgrssBar1.Location = new Point(12, 103);
            prgrssBar1.Name = "prgrssBar1";
            prgrssBar1.Size = new Size(625, 23);
            prgrssBar1.TabIndex = 1;
            // 
            // prgrssBar2
            // 
            prgrssBar2.Location = new Point(12, 167);
            prgrssBar2.Name = "prgrssBar2";
            prgrssBar2.Size = new Size(625, 23);
            prgrssBar2.TabIndex = 2;
            prgrssBar2.Click += progressBar2_Click;
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(309, 12);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(75, 23);
            btnCounter.TabIndex = 3;
            btnCounter.Text = "Sayaç";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 357);
            Controls.Add(btnCounter);
            Controls.Add(prgrssBar2);
            Controls.Add(prgrssBar1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private ProgressBar prgrssBar1;
        private ProgressBar prgrssBar2;
        private Button btnCounter;
    }
}
