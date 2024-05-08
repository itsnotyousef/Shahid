
namespace Shahid
{
    partial class AdminForm
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
            this.AdminAddVideoButton = new System.Windows.Forms.Button();
            this.AdminDeleteVideoButton = new System.Windows.Forms.Button();
            this.AdminShowAllUsersButton = new System.Windows.Forms.Button();
            this.AdminShowStatisticsButton = new System.Windows.Forms.Button();
            this.AdminLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminAddVideoButton
            // 
            this.AdminAddVideoButton.BackColor = System.Drawing.Color.Black;
            this.AdminAddVideoButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAddVideoButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminAddVideoButton.Location = new System.Drawing.Point(200, 41);
            this.AdminAddVideoButton.Name = "AdminAddVideoButton";
            this.AdminAddVideoButton.Size = new System.Drawing.Size(268, 190);
            this.AdminAddVideoButton.TabIndex = 0;
            this.AdminAddVideoButton.Text = "Add Video";
            this.AdminAddVideoButton.UseVisualStyleBackColor = false;
            this.AdminAddVideoButton.Click += new System.EventHandler(this.AdminAddVideoButton_Click);
            // 
            // AdminDeleteVideoButton
            // 
            this.AdminDeleteVideoButton.BackColor = System.Drawing.Color.Black;
            this.AdminDeleteVideoButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDeleteVideoButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminDeleteVideoButton.Location = new System.Drawing.Point(640, 40);
            this.AdminDeleteVideoButton.Name = "AdminDeleteVideoButton";
            this.AdminDeleteVideoButton.Size = new System.Drawing.Size(268, 191);
            this.AdminDeleteVideoButton.TabIndex = 1;
            this.AdminDeleteVideoButton.Text = "Delete Video";
            this.AdminDeleteVideoButton.UseVisualStyleBackColor = false;
            this.AdminDeleteVideoButton.Click += new System.EventHandler(this.AdminDeleteVideoButton_Click);
            // 
            // AdminShowAllUsersButton
            // 
            this.AdminShowAllUsersButton.BackColor = System.Drawing.Color.Black;
            this.AdminShowAllUsersButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminShowAllUsersButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminShowAllUsersButton.Location = new System.Drawing.Point(640, 280);
            this.AdminShowAllUsersButton.Name = "AdminShowAllUsersButton";
            this.AdminShowAllUsersButton.Size = new System.Drawing.Size(268, 191);
            this.AdminShowAllUsersButton.TabIndex = 2;
            this.AdminShowAllUsersButton.Text = "Show All Users";
            this.AdminShowAllUsersButton.UseVisualStyleBackColor = false;
            this.AdminShowAllUsersButton.Click += new System.EventHandler(this.AdminShowAllUsersButton_Click);
            // 
            // AdminShowStatisticsButton
            // 
            this.AdminShowStatisticsButton.BackColor = System.Drawing.Color.Black;
            this.AdminShowStatisticsButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminShowStatisticsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminShowStatisticsButton.Location = new System.Drawing.Point(200, 280);
            this.AdminShowStatisticsButton.Name = "AdminShowStatisticsButton";
            this.AdminShowStatisticsButton.Size = new System.Drawing.Size(268, 191);
            this.AdminShowStatisticsButton.TabIndex = 3;
            this.AdminShowStatisticsButton.Text = "Show  Rate";
            this.AdminShowStatisticsButton.UseVisualStyleBackColor = false;
            this.AdminShowStatisticsButton.Click += new System.EventHandler(this.AdminShowStatisticsButton_Click);
            // 
            // AdminLogOut
            // 
            this.AdminLogOut.BackColor = System.Drawing.Color.Black;
            this.AdminLogOut.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogOut.ForeColor = System.Drawing.Color.DarkCyan;
            this.AdminLogOut.Location = new System.Drawing.Point(426, 510);
            this.AdminLogOut.Name = "AdminLogOut";
            this.AdminLogOut.Size = new System.Drawing.Size(268, 191);
            this.AdminLogOut.TabIndex = 4;
            this.AdminLogOut.Text = "Log Out";
            this.AdminLogOut.UseVisualStyleBackColor = false;
            this.AdminLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1151, 713);
            this.Controls.Add(this.AdminLogOut);
            this.Controls.Add(this.AdminShowStatisticsButton);
            this.Controls.Add(this.AdminShowAllUsersButton);
            this.Controls.Add(this.AdminDeleteVideoButton);
            this.Controls.Add(this.AdminAddVideoButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminAddVideoButton;
        private System.Windows.Forms.Button AdminDeleteVideoButton;
        private System.Windows.Forms.Button AdminShowAllUsersButton;
        private System.Windows.Forms.Button AdminShowStatisticsButton;
        private System.Windows.Forms.Button AdminLogOut;
    }
}