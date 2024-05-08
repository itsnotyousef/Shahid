
namespace Shahid
{
    partial class UserMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainMenu));
            this.SearchVideoButton = new System.Windows.Forms.Button();
            this.ShowListsButton = new System.Windows.Forms.Button();
            this.SearchVideoTextBox = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.PlayVideoOneButton = new System.Windows.Forms.Button();
            this.PlayVideoTwoButton = new System.Windows.Forms.Button();
            this.AddVideoOneRateButton = new System.Windows.Forms.Button();
            this.AddVideoTwoRateButton = new System.Windows.Forms.Button();
            this.AddVideoOneToFavoriteListButton = new System.Windows.Forms.Button();
            this.AddVideoTwoToFavoriteListButton = new System.Windows.Forms.Button();
            this.AddVideoOneToWatchLaterButton = new System.Windows.Forms.Button();
            this.AddVideoTwoToWatchLaterButton = new System.Windows.Forms.Button();
            this.ShowVideoOneDetailsButton = new System.Windows.Forms.Button();
            this.ShowVideoTwoDetailsButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.RatingVidOneTextBox = new System.Windows.Forms.TextBox();
            this.RatingVidTwoTextBox = new System.Windows.Forms.TextBox();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchVideoButton
            // 
            this.SearchVideoButton.BackColor = System.Drawing.Color.Black;
            this.SearchVideoButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchVideoButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.SearchVideoButton.Location = new System.Drawing.Point(668, 82);
            this.SearchVideoButton.Name = "SearchVideoButton";
            this.SearchVideoButton.Size = new System.Drawing.Size(288, 47);
            this.SearchVideoButton.TabIndex = 0;
            this.SearchVideoButton.Text = "Search Video";
            this.SearchVideoButton.UseVisualStyleBackColor = false;
            this.SearchVideoButton.Click += new System.EventHandler(this.SearchVideoButton_Click);
            // 
            // ShowListsButton
            // 
            this.ShowListsButton.BackColor = System.Drawing.Color.Black;
            this.ShowListsButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowListsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ShowListsButton.Location = new System.Drawing.Point(742, 640);
            this.ShowListsButton.Name = "ShowListsButton";
            this.ShowListsButton.Size = new System.Drawing.Size(119, 104);
            this.ShowListsButton.TabIndex = 1;
            this.ShowListsButton.Text = "Show Lists";
            this.ShowListsButton.UseVisualStyleBackColor = false;
            this.ShowListsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchVideoTextBox
            // 
            this.SearchVideoTextBox.BackColor = System.Drawing.Color.Black;
            this.SearchVideoTextBox.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchVideoTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.SearchVideoTextBox.Location = new System.Drawing.Point(668, 12);
            this.SearchVideoTextBox.Name = "SearchVideoTextBox";
            this.SearchVideoTextBox.Size = new System.Drawing.Size(288, 33);
            this.SearchVideoTextBox.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(22, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(606, 374);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // PlayVideoOneButton
            // 
            this.PlayVideoOneButton.BackColor = System.Drawing.Color.Black;
            this.PlayVideoOneButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayVideoOneButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.PlayVideoOneButton.Location = new System.Drawing.Point(22, 508);
            this.PlayVideoOneButton.Name = "PlayVideoOneButton";
            this.PlayVideoOneButton.Size = new System.Drawing.Size(166, 54);
            this.PlayVideoOneButton.TabIndex = 7;
            this.PlayVideoOneButton.Text = "Play Video";
            this.PlayVideoOneButton.UseVisualStyleBackColor = false;
            this.PlayVideoOneButton.Click += new System.EventHandler(this.PlayVideoOneButton_Click);
            // 
            // PlayVideoTwoButton
            // 
            this.PlayVideoTwoButton.BackColor = System.Drawing.Color.Black;
            this.PlayVideoTwoButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayVideoTwoButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.PlayVideoTwoButton.Location = new System.Drawing.Point(989, 508);
            this.PlayVideoTwoButton.Name = "PlayVideoTwoButton";
            this.PlayVideoTwoButton.Size = new System.Drawing.Size(177, 54);
            this.PlayVideoTwoButton.TabIndex = 8;
            this.PlayVideoTwoButton.Text = "Play Video";
            this.PlayVideoTwoButton.UseVisualStyleBackColor = false;
            this.PlayVideoTwoButton.Click += new System.EventHandler(this.PlayVideoTwoButton_Click);
            // 
            // AddVideoOneRateButton
            // 
            this.AddVideoOneRateButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoOneRateButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoOneRateButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoOneRateButton.Location = new System.Drawing.Point(22, 426);
            this.AddVideoOneRateButton.Name = "AddVideoOneRateButton";
            this.AddVideoOneRateButton.Size = new System.Drawing.Size(166, 57);
            this.AddVideoOneRateButton.TabIndex = 9;
            this.AddVideoOneRateButton.Text = "Add Rate ";
            this.AddVideoOneRateButton.UseVisualStyleBackColor = false;
            this.AddVideoOneRateButton.Click += new System.EventHandler(this.AddVideoOneRateButton_Click);
            // 
            // AddVideoTwoRateButton
            // 
            this.AddVideoTwoRateButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoTwoRateButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoTwoRateButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoTwoRateButton.Location = new System.Drawing.Point(989, 431);
            this.AddVideoTwoRateButton.Name = "AddVideoTwoRateButton";
            this.AddVideoTwoRateButton.Size = new System.Drawing.Size(177, 52);
            this.AddVideoTwoRateButton.TabIndex = 10;
            this.AddVideoTwoRateButton.Text = "Add Rate";
            this.AddVideoTwoRateButton.UseVisualStyleBackColor = false;
            this.AddVideoTwoRateButton.Click += new System.EventHandler(this.AddVideoTwoRateButton_Click);
            // 
            // AddVideoOneToFavoriteListButton
            // 
            this.AddVideoOneToFavoriteListButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoOneToFavoriteListButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoOneToFavoriteListButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoOneToFavoriteListButton.Location = new System.Drawing.Point(22, 572);
            this.AddVideoOneToFavoriteListButton.Name = "AddVideoOneToFavoriteListButton";
            this.AddVideoOneToFavoriteListButton.Size = new System.Drawing.Size(166, 54);
            this.AddVideoOneToFavoriteListButton.TabIndex = 11;
            this.AddVideoOneToFavoriteListButton.Text = "Add To Favorite List";
            this.AddVideoOneToFavoriteListButton.UseVisualStyleBackColor = false;
            this.AddVideoOneToFavoriteListButton.Click += new System.EventHandler(this.AddVideoOneToFavoriteListButton_Click);
            // 
            // AddVideoTwoToFavoriteListButton
            // 
            this.AddVideoTwoToFavoriteListButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoTwoToFavoriteListButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoTwoToFavoriteListButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoTwoToFavoriteListButton.Location = new System.Drawing.Point(989, 572);
            this.AddVideoTwoToFavoriteListButton.Name = "AddVideoTwoToFavoriteListButton";
            this.AddVideoTwoToFavoriteListButton.Size = new System.Drawing.Size(177, 54);
            this.AddVideoTwoToFavoriteListButton.TabIndex = 12;
            this.AddVideoTwoToFavoriteListButton.Text = "Add To Favorite List";
            this.AddVideoTwoToFavoriteListButton.UseVisualStyleBackColor = false;
            this.AddVideoTwoToFavoriteListButton.Click += new System.EventHandler(this.AddVideoTwoToFavoriteListButton_Click);
            // 
            // AddVideoOneToWatchLaterButton
            // 
            this.AddVideoOneToWatchLaterButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoOneToWatchLaterButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoOneToWatchLaterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoOneToWatchLaterButton.Location = new System.Drawing.Point(22, 640);
            this.AddVideoOneToWatchLaterButton.Name = "AddVideoOneToWatchLaterButton";
            this.AddVideoOneToWatchLaterButton.Size = new System.Drawing.Size(166, 54);
            this.AddVideoOneToWatchLaterButton.TabIndex = 13;
            this.AddVideoOneToWatchLaterButton.Text = "Add To Watch Later ";
            this.AddVideoOneToWatchLaterButton.UseVisualStyleBackColor = false;
            this.AddVideoOneToWatchLaterButton.Click += new System.EventHandler(this.AddVideoOneToWatchLaterButton_Click);
            // 
            // AddVideoTwoToWatchLaterButton
            // 
            this.AddVideoTwoToWatchLaterButton.BackColor = System.Drawing.Color.Black;
            this.AddVideoTwoToWatchLaterButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideoTwoToWatchLaterButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddVideoTwoToWatchLaterButton.Location = new System.Drawing.Point(989, 640);
            this.AddVideoTwoToWatchLaterButton.Name = "AddVideoTwoToWatchLaterButton";
            this.AddVideoTwoToWatchLaterButton.Size = new System.Drawing.Size(177, 54);
            this.AddVideoTwoToWatchLaterButton.TabIndex = 14;
            this.AddVideoTwoToWatchLaterButton.Text = "Add To Watch Later ";
            this.AddVideoTwoToWatchLaterButton.UseVisualStyleBackColor = false;
            this.AddVideoTwoToWatchLaterButton.Click += new System.EventHandler(this.AddVideoTwoToWatchLaterButton_Click);
            // 
            // ShowVideoOneDetailsButton
            // 
            this.ShowVideoOneDetailsButton.BackColor = System.Drawing.Color.Black;
            this.ShowVideoOneDetailsButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVideoOneDetailsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ShowVideoOneDetailsButton.Location = new System.Drawing.Point(22, 708);
            this.ShowVideoOneDetailsButton.Name = "ShowVideoOneDetailsButton";
            this.ShowVideoOneDetailsButton.Size = new System.Drawing.Size(166, 53);
            this.ShowVideoOneDetailsButton.TabIndex = 15;
            this.ShowVideoOneDetailsButton.Text = "Show Video Details";
            this.ShowVideoOneDetailsButton.UseVisualStyleBackColor = false;
            this.ShowVideoOneDetailsButton.Click += new System.EventHandler(this.ShowVideoOneDetailsButton_Click);
            // 
            // ShowVideoTwoDetailsButton
            // 
            this.ShowVideoTwoDetailsButton.BackColor = System.Drawing.Color.Black;
            this.ShowVideoTwoDetailsButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowVideoTwoDetailsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ShowVideoTwoDetailsButton.Location = new System.Drawing.Point(989, 708);
            this.ShowVideoTwoDetailsButton.Name = "ShowVideoTwoDetailsButton";
            this.ShowVideoTwoDetailsButton.Size = new System.Drawing.Size(177, 53);
            this.ShowVideoTwoDetailsButton.TabIndex = 16;
            this.ShowVideoTwoDetailsButton.Text = "Show Video Details";
            this.ShowVideoTwoDetailsButton.UseVisualStyleBackColor = false;
            this.ShowVideoTwoDetailsButton.Click += new System.EventHandler(this.ShowVideoTwoDetailsButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTextBox1.Location = new System.Drawing.Point(226, 513);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(402, 249);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTextBox2.Location = new System.Drawing.Point(1207, 512);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(388, 249);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(989, 12);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(606, 374);
            this.axWindowsMediaPlayer2.TabIndex = 19;
            // 
            // RatingVidOneTextBox
            // 
            this.RatingVidOneTextBox.BackColor = System.Drawing.Color.Black;
            this.RatingVidOneTextBox.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingVidOneTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.RatingVidOneTextBox.Location = new System.Drawing.Point(226, 431);
            this.RatingVidOneTextBox.Name = "RatingVidOneTextBox";
            this.RatingVidOneTextBox.Size = new System.Drawing.Size(402, 27);
            this.RatingVidOneTextBox.TabIndex = 20;
            // 
            // RatingVidTwoTextBox
            // 
            this.RatingVidTwoTextBox.BackColor = System.Drawing.Color.Black;
            this.RatingVidTwoTextBox.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingVidTwoTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.RatingVidTwoTextBox.Location = new System.Drawing.Point(1207, 438);
            this.RatingVidTwoTextBox.Name = "RatingVidTwoTextBox";
            this.RatingVidTwoTextBox.Size = new System.Drawing.Size(388, 27);
            this.RatingVidTwoTextBox.TabIndex = 21;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogOutButton.Location = new System.Drawing.Point(818, 508);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(117, 102);
            this.LogOutButton.TabIndex = 23;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Black;
            this.SettingsButton.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.SettingsButton.Location = new System.Drawing.Point(668, 508);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(119, 102);
            this.SettingsButton.TabIndex = 24;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // UserMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1607, 782);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.RatingVidTwoTextBox);
            this.Controls.Add(this.RatingVidOneTextBox);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ShowVideoTwoDetailsButton);
            this.Controls.Add(this.ShowVideoOneDetailsButton);
            this.Controls.Add(this.AddVideoTwoToWatchLaterButton);
            this.Controls.Add(this.AddVideoOneToWatchLaterButton);
            this.Controls.Add(this.AddVideoTwoToFavoriteListButton);
            this.Controls.Add(this.AddVideoOneToFavoriteListButton);
            this.Controls.Add(this.AddVideoTwoRateButton);
            this.Controls.Add(this.AddVideoOneRateButton);
            this.Controls.Add(this.PlayVideoTwoButton);
            this.Controls.Add(this.PlayVideoOneButton);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SearchVideoTextBox);
            this.Controls.Add(this.ShowListsButton);
            this.Controls.Add(this.SearchVideoButton);
            this.Name = "UserMainMenu";
            this.Text = "UserMainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.UserMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchVideoButton;
        private System.Windows.Forms.Button ShowListsButton;
        private System.Windows.Forms.TextBox SearchVideoTextBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button PlayVideoOneButton;
        private System.Windows.Forms.Button PlayVideoTwoButton;
        private System.Windows.Forms.Button AddVideoOneRateButton;
        private System.Windows.Forms.Button AddVideoTwoRateButton;
        private System.Windows.Forms.Button AddVideoOneToFavoriteListButton;
        private System.Windows.Forms.Button AddVideoTwoToFavoriteListButton;
        private System.Windows.Forms.Button AddVideoOneToWatchLaterButton;
        private System.Windows.Forms.Button AddVideoTwoToWatchLaterButton;
        private System.Windows.Forms.Button ShowVideoOneDetailsButton;
        private System.Windows.Forms.Button ShowVideoTwoDetailsButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TextBox RatingVidOneTextBox;
        private System.Windows.Forms.TextBox RatingVidTwoTextBox;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}