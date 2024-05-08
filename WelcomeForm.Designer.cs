
namespace Shahid
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.WelcomeSignUpButton = new System.Windows.Forms.Button();
            this.WelcomeLogInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shahid";
            // 
            // WelcomeSignUpButton
            // 
            this.WelcomeSignUpButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeSignUpButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.WelcomeSignUpButton.Location = new System.Drawing.Point(246, 392);
            this.WelcomeSignUpButton.Name = "WelcomeSignUpButton";
            this.WelcomeSignUpButton.Size = new System.Drawing.Size(301, 200);
            this.WelcomeSignUpButton.TabIndex = 1;
            this.WelcomeSignUpButton.Text = "Sign Up";
            this.WelcomeSignUpButton.UseVisualStyleBackColor = false;
            this.WelcomeSignUpButton.Click += new System.EventHandler(this.WelcomeSignUpButton_Click);
            // 
            // WelcomeLogInButton
            // 
            this.WelcomeLogInButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeLogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLogInButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.WelcomeLogInButton.Location = new System.Drawing.Point(887, 392);
            this.WelcomeLogInButton.Name = "WelcomeLogInButton";
            this.WelcomeLogInButton.Size = new System.Drawing.Size(301, 200);
            this.WelcomeLogInButton.TabIndex = 2;
            this.WelcomeLogInButton.Text = "Log In";
            this.WelcomeLogInButton.UseVisualStyleBackColor = false;
            this.WelcomeLogInButton.Click += new System.EventHandler(this.WelcomeLogInButton_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1307, 667);
            this.Controls.Add(this.WelcomeLogInButton);
            this.Controls.Add(this.WelcomeSignUpButton);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "WelcomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button WelcomeSignUpButton;
        private System.Windows.Forms.Button WelcomeLogInButton;
    }
}