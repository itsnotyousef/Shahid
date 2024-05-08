
namespace Shahid
{
    partial class LoginForm
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
            this.LogInEmailTextBox = new System.Windows.Forms.TextBox();
            this.LogInPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogInEmailLabel = new System.Windows.Forms.Label();
            this.LogInPasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.CheckAccountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInEmailTextBox
            // 
            this.LogInEmailTextBox.BackColor = System.Drawing.Color.Black;
            this.LogInEmailTextBox.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInEmailTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogInEmailTextBox.Location = new System.Drawing.Point(261, 149);
            this.LogInEmailTextBox.Name = "LogInEmailTextBox";
            this.LogInEmailTextBox.Size = new System.Drawing.Size(277, 33);
            this.LogInEmailTextBox.TabIndex = 0;
            // 
            // LogInPasswordTextBox
            // 
            this.LogInPasswordTextBox.BackColor = System.Drawing.Color.Black;
            this.LogInPasswordTextBox.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInPasswordTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogInPasswordTextBox.Location = new System.Drawing.Point(261, 219);
            this.LogInPasswordTextBox.Name = "LogInPasswordTextBox";
            this.LogInPasswordTextBox.Size = new System.Drawing.Size(277, 33);
            this.LogInPasswordTextBox.TabIndex = 1;
            // 
            // LogInEmailLabel
            // 
            this.LogInEmailLabel.AutoSize = true;
            this.LogInEmailLabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInEmailLabel.Location = new System.Drawing.Point(72, 147);
            this.LogInEmailLabel.Name = "LogInEmailLabel";
            this.LogInEmailLabel.Size = new System.Drawing.Size(125, 34);
            this.LogInEmailLabel.TabIndex = 2;
            this.LogInEmailLabel.Text = "E-mail";
            this.LogInEmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogInPasswordLabel
            // 
            this.LogInPasswordLabel.AutoSize = true;
            this.LogInPasswordLabel.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInPasswordLabel.Location = new System.Drawing.Point(54, 217);
            this.LogInPasswordLabel.Name = "LogInPasswordLabel";
            this.LogInPasswordLabel.Size = new System.Drawing.Size(179, 34);
            this.LogInPasswordLabel.TabIndex = 3;
            this.LogInPasswordLabel.Text = "Password";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(296, 36);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(202, 63);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Login";
            // 
            // LogInButton
            // 
            this.LogInButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogInButton.BackColor = System.Drawing.Color.Black;
            this.LogInButton.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogInButton.Location = new System.Drawing.Point(261, 341);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(277, 66);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // CheckAccountLabel
            // 
            this.CheckAccountLabel.AutoSize = true;
            this.CheckAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAccountLabel.ForeColor = System.Drawing.Color.Red;
            this.CheckAccountLabel.Location = new System.Drawing.Point(279, 400);
            this.CheckAccountLabel.Name = "CheckAccountLabel";
            this.CheckAccountLabel.Size = new System.Drawing.Size(0, 20);
            this.CheckAccountLabel.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckAccountLabel);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LogInPasswordLabel);
            this.Controls.Add(this.LogInEmailLabel);
            this.Controls.Add(this.LogInPasswordTextBox);
            this.Controls.Add(this.LogInEmailTextBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogInEmailTextBox;
        private System.Windows.Forms.TextBox LogInPasswordTextBox;
        private System.Windows.Forms.Label LogInEmailLabel;
        private System.Windows.Forms.Label LogInPasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Label CheckAccountLabel;
    }
}