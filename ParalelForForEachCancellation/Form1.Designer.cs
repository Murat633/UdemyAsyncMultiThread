namespace ParalelForForEachCancellation
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
            rtbxTotal = new RichTextBox();
            btnStop = new Button();
            btnCounter = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(44, 37);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(98, 36);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // rtbxTotal
            // 
            rtbxTotal.Location = new Point(44, 106);
            rtbxTotal.Name = "rtbxTotal";
            rtbxTotal.Size = new Size(98, 293);
            rtbxTotal.TabIndex = 1;
            rtbxTotal.Text = "";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(239, 37);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(98, 36);
            btnStop.TabIndex = 2;
            btnStop.Text = "stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(148, 37);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(77, 36);
            btnCounter.TabIndex = 3;
            btnCounter.Text = "Arttır";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 411);
            Controls.Add(btnCounter);
            Controls.Add(btnStop);
            Controls.Add(rtbxTotal);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private RichTextBox rtbxTotal;
        private Button btnStop;
        private Button btnCounter;
    }
}
