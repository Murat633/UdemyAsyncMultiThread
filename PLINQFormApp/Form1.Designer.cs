namespace PLINQFormApp
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
            btnStop = new Button();
            lbxNumbers = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkGreen;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("SimSun", 9.75F);
            btnStart.ForeColor = Color.White;
            btnStart.ImageAlign = ContentAlignment.MiddleLeft;
            btnStart.Location = new Point(66, 21);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(134, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Başlat";
            btnStart.TextAlign = ContentAlignment.MiddleLeft;
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.IndianRed;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("SimSun", 9.75F);
            btnStop.ForeColor = Color.White;
            btnStop.ImageAlign = ContentAlignment.MiddleLeft;
            btnStop.Location = new Point(97, 50);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(70, 23);
            btnStop.TabIndex = 1;
            btnStop.Text = "İptal Et";
            btnStop.TextAlign = ContentAlignment.MiddleLeft;
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lbxNumbers
            // 
            lbxNumbers.FormattingEnabled = true;
            lbxNumbers.ItemHeight = 15;
            lbxNumbers.Location = new Point(38, 81);
            lbxNumbers.Name = "lbxNumbers";
            lbxNumbers.Size = new Size(193, 304);
            lbxNumbers.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 450);
            Controls.Add(lbxNumbers);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "CancellationToken";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private ListBox lbxNumbers;
    }
}
