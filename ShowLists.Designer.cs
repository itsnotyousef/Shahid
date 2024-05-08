
namespace Shahid
{
    partial class ShowLists
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
            this.WatchLater = new System.Windows.Forms.Label();
            this.FavoriteList = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SearchVidShowListTextBox = new System.Windows.Forms.TextBox();
            this.SearchingByVideoName = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.ListsMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WatchLater
            // 
            this.WatchLater.AutoSize = true;
            this.WatchLater.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchLater.Location = new System.Drawing.Point(12, 29);
            this.WatchLater.Name = "WatchLater";
            this.WatchLater.Size = new System.Drawing.Size(336, 48);
            this.WatchLater.TabIndex = 0;
            this.WatchLater.Text = "Watch Later";
            // 
            // FavoriteList
            // 
            this.FavoriteList.AutoSize = true;
            this.FavoriteList.Font = new System.Drawing.Font("Ravie", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FavoriteList.Location = new System.Drawing.Point(392, 29);
            this.FavoriteList.Name = "FavoriteList";
            this.FavoriteList.Size = new System.Drawing.Size(350, 48);
            this.FavoriteList.TabIndex = 1;
            this.FavoriteList.Text = "Favorite List";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTextBox1.Location = new System.Drawing.Point(20, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 373);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SearchVidShowListTextBox
            // 
            this.SearchVidShowListTextBox.BackColor = System.Drawing.Color.Black;
            this.SearchVidShowListTextBox.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchVidShowListTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.SearchVidShowListTextBox.Location = new System.Drawing.Point(479, 587);
            this.SearchVidShowListTextBox.Name = "SearchVidShowListTextBox";
            this.SearchVidShowListTextBox.Size = new System.Drawing.Size(249, 33);
            this.SearchVidShowListTextBox.TabIndex = 4;
            // 
            // SearchingByVideoName
            // 
            this.SearchingByVideoName.BackColor = System.Drawing.Color.Black;
            this.SearchingByVideoName.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchingByVideoName.ForeColor = System.Drawing.Color.DarkCyan;
            this.SearchingByVideoName.Location = new System.Drawing.Point(241, 571);
            this.SearchingByVideoName.Name = "SearchingByVideoName";
            this.SearchingByVideoName.Size = new System.Drawing.Size(215, 64);
            this.SearchingByVideoName.TabIndex = 5;
            this.SearchingByVideoName.Text = "Search Video";
            this.SearchingByVideoName.UseVisualStyleBackColor = false;
            this.SearchingByVideoName.Click += new System.EventHandler(this.SearchingByVideoName_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox2.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkCyan;
            this.richTextBox2.Location = new System.Drawing.Point(400, 109);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(328, 373);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // ListsMainMenuButton
            // 
            this.ListsMainMenuButton.BackColor = System.Drawing.Color.Black;
            this.ListsMainMenuButton.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListsMainMenuButton.ForeColor = System.Drawing.Color.DarkCyan;
            this.ListsMainMenuButton.Location = new System.Drawing.Point(20, 571);
            this.ListsMainMenuButton.Name = "ListsMainMenuButton";
            this.ListsMainMenuButton.Size = new System.Drawing.Size(215, 64);
            this.ListsMainMenuButton.TabIndex = 7;
            this.ListsMainMenuButton.Text = "Main Menu";
            this.ListsMainMenuButton.UseVisualStyleBackColor = false;
            this.ListsMainMenuButton.Click += new System.EventHandler(this.ListsMainMenuButton_Click);
            // 
            // ShowLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(857, 660);
            this.Controls.Add(this.ListsMainMenuButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.SearchingByVideoName);
            this.Controls.Add(this.SearchVidShowListTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FavoriteList);
            this.Controls.Add(this.WatchLater);
            this.Name = "ShowLists";
            this.Text = "ShowLists";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowLists_FormClosing);
            this.Load += new System.EventHandler(this.ShowLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WatchLater;
        private System.Windows.Forms.Label FavoriteList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox SearchVidShowListTextBox;
        private System.Windows.Forms.Button SearchingByVideoName;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button ListsMainMenuButton;
    }
}