namespace TestHarness
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
            btnSlow = new Button();
            btnFast = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // btnSlow
            // 
            btnSlow.Location = new Point(151, 110);
            btnSlow.Name = "btnSlow";
            btnSlow.Size = new Size(75, 23);
            btnSlow.TabIndex = 0;
            btnSlow.Text = "Slow";
            btnSlow.UseVisualStyleBackColor = true;
            btnSlow.Click += button1_Click;
            // 
            // btnFast
            // 
            btnFast.Location = new Point(288, 110);
            btnFast.Name = "btnFast";
            btnFast.Size = new Size(75, 23);
            btnFast.TabIndex = 1;
            btnFast.Text = "Fast";
            btnFast.UseVisualStyleBackColor = true;
            btnFast.Click += button2_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(151, 158);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(589, 248);
            txtOutput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOutput);
            Controls.Add(btnFast);
            Controls.Add(btnSlow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSlow;
        private Button btnFast;
        private TextBox txtOutput;
    }
}
