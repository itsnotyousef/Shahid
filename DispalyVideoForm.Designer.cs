
namespace Shahid
{
    partial class DispalyVideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispalyVideoForm));
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.RateDisplayedVideoButton = new System.Windows.Forms.Button();
            this.AddDisplayedVideoToFavoriteListButton = new System.Windows.Forms.Button();
            this.ShowDisplayVidDetailsButton = new System.Windows.Forms.Button();
            this.AddDisplayedVidToWatchLaterButton = new System.Windows.Forms.Button();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.DisplayedVideoRichBox = new System.Windows.Forms.RichTextBox();
            this.DisplayedVidTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(857, 463);
            this.axWindowsMediaPlayer3.TabIndex = 0;
            // 
            // RateDisplayedVideoButton
            // 
            this.RateDisplayedVideoButton.BackColor = System.Drawing.Color.Black;
            this.RateDisplayedVideoButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateDisplayedVideoButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.RateDisplayedVideoButton.Location = new System.Drawing.Point(12, 490);
            this.RateDisplayedVideoButton.Name = "RateDisplayedVideoButton";
            this.RateDisplayedVideoButton.Size = new System.Drawing.Size(242, 51);
            this.RateDisplayedVideoButton.TabIndex = 1;
            this.RateDisplayedVideoButton.Text = "Rate";
            this.RateDisplayedVideoButton.UseVisualStyleBackColor = false;
            this.RateDisplayedVideoButton.Click += new System.EventHandler(this.RateDisplayedVideoButton_Click);
            // 
            // AddDisplayedVideoToFavoriteListButton
            // 
            this.AddDisplayedVideoToFavoriteListButton.BackColor = System.Drawing.Color.Black;
            this.AddDisplayedVideoToFavoriteListButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDisplayedVideoToFavoriteListButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddDisplayedVideoToFavoriteListButton.Location = new System.Drawing.Point(300, 649);
            this.AddDisplayedVideoToFavoriteListButton.Name = "AddDisplayedVideoToFavoriteListButton";
            this.AddDisplayedVideoToFavoriteListButton.Size = new System.Drawing.Size(249, 127);
            this.AddDisplayedVideoToFavoriteListButton.TabIndex = 2;
            this.AddDisplayedVideoToFavoriteListButton.Text = "Add To Favorite List";
            this.AddDisplayedVideoToFavoriteListButton.UseVisualStyleBackColor = false;
            this.AddDisplayedVideoToFavoriteListButton.Click += new System.EventHandler(this.AddDisplayedVideoToFavoriteListButton_Click);
            // 
            // ShowDisplayVidDetailsButton
            // 
            this.ShowDisplayVidDetailsButton.BackColor = System.Drawing.Color.Black;
            this.ShowDisplayVidDetailsButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDisplayVidDetailsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ShowDisplayVidDetailsButton.Location = new System.Drawing.Point(957, 649);
            this.ShowDisplayVidDetailsButton.Name = "ShowDisplayVidDetailsButton";
            this.ShowDisplayVidDetailsButton.Size = new System.Drawing.Size(251, 127);
            this.ShowDisplayVidDetailsButton.TabIndex = 3;
            this.ShowDisplayVidDetailsButton.Text = "Show Video Details";
            this.ShowDisplayVidDetailsButton.UseVisualStyleBackColor = false;
            this.ShowDisplayVidDetailsButton.Click += new System.EventHandler(this.ShowDisplayVidDetailsButton_Click);
            // 
            // AddDisplayedVidToWatchLaterButton
            // 
            this.AddDisplayedVidToWatchLaterButton.BackColor = System.Drawing.Color.Black;
            this.AddDisplayedVidToWatchLaterButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDisplayedVidToWatchLaterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddDisplayedVidToWatchLaterButton.Location = new System.Drawing.Point(600, 649);
            this.AddDisplayedVidToWatchLaterButton.Name = "AddDisplayedVidToWatchLaterButton";
            this.AddDisplayedVidToWatchLaterButton.Size = new System.Drawing.Size(251, 127);
            this.AddDisplayedVidToWatchLaterButton.TabIndex = 4;
            this.AddDisplayedVidToWatchLaterButton.Text = "Add To Watch Later";
            this.AddDisplayedVidToWatchLaterButton.UseVisualStyleBackColor = false;
            this.AddDisplayedVidToWatchLaterButton.Click += new System.EventHandler(this.AddDisplayedVidToWatchLaterButton_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Black;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.BackToMainMenuButton.Location = new System.Drawing.Point(12, 649);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(249, 127);
            this.BackToMainMenuButton.TabIndex = 5;
            this.BackToMainMenuButton.Text = "Main Menu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // DisplayedVideoRichBox
            // 
            this.DisplayedVideoRichBox.BackColor = System.Drawing.Color.Black;
            this.DisplayedVideoRichBox.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayedVideoRichBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.DisplayedVideoRichBox.Location = new System.Drawing.Point(957, 25);
            this.DisplayedVideoRichBox.Name = "DisplayedVideoRichBox";
            this.DisplayedVideoRichBox.Size = new System.Drawing.Size(405, 450);
            this.DisplayedVideoRichBox.TabIndex = 6;
            this.DisplayedVideoRichBox.Text = "";
            // 
            // DisplayedVidTextBox
            // 
            this.DisplayedVidTextBox.BackColor = System.Drawing.Color.Black;
            this.DisplayedVidTextBox.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayedVidTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.DisplayedVidTextBox.Location = new System.Drawing.Point(300, 506);
            this.DisplayedVidTextBox.Name = "DisplayedVidTextBox";
            this.DisplayedVidTextBox.Size = new System.Drawing.Size(323, 35);
            this.DisplayedVidTextBox.TabIndex = 7;
            // 
            // DispalyVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1414, 797);
            this.Controls.Add(this.DisplayedVidTextBox);
            this.Controls.Add(this.DisplayedVideoRichBox);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.AddDisplayedVidToWatchLaterButton);
            this.Controls.Add(this.ShowDisplayVidDetailsButton);
            this.Controls.Add(this.AddDisplayedVideoToFavoriteListButton);
            this.Controls.Add(this.RateDisplayedVideoButton);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Name = "DispalyVideoForm";
            this.Text = "DispalyVideoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DispalyVideoForm_FormClosing);
            this.Load += new System.EventHandler(this.DispalyVideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Button RateDisplayedVideoButton;
        private System.Windows.Forms.Button AddDisplayedVideoToFavoriteListButton;
        private System.Windows.Forms.Button ShowDisplayVidDetailsButton;
        private System.Windows.Forms.Button AddDisplayedVidToWatchLaterButton;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.RichTextBox DisplayedVideoRichBox;
        private System.Windows.Forms.TextBox DisplayedVidTextBox;
    }
}