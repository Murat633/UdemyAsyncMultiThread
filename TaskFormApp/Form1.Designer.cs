namespace TaskFormApp
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
            btnRead = new Button();
            tbxRead = new RichTextBox();
            btnCounter = new Button();
            tbxCounter = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(67, 21);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 0;
            btnRead.Text = "Oku";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // tbxRead
            // 
            tbxRead.Location = new Point(67, 63);
            tbxRead.Name = "tbxRead";
            tbxRead.Size = new Size(197, 273);
            tbxRead.TabIndex = 1;
            tbxRead.Text = "";
            // 
            // btnCounter
            // 
            btnCounter.Location = new Point(298, 21);
            btnCounter.Name = "btnCounter";
            btnCounter.Size = new Size(75, 23);
            btnCounter.TabIndex = 2;
            btnCounter.Text = "Sayaç Arttır";
            btnCounter.UseVisualStyleBackColor = true;
            btnCounter.Click += btnCounter_Click;
            // 
            // tbxCounter
            // 
            tbxCounter.Location = new Point(298, 63);
            tbxCounter.Name = "tbxCounter";
            tbxCounter.Size = new Size(75, 23);
            tbxCounter.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxCounter);
            Controls.Add(btnCounter);
            Controls.Add(tbxRead);
            Controls.Add(btnRead);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private RichTextBox tbxRead;
        private Button btnCounter;
        private TextBox tbxCounter;
    }
}
