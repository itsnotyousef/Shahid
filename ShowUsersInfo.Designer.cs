
namespace Shahid
{
    partial class ShowUsersInfo
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
            this.AllUsersRichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AllUsersRichBox
            // 
            this.AllUsersRichBox.BackColor = System.Drawing.Color.Black;
            this.AllUsersRichBox.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllUsersRichBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.AllUsersRichBox.Location = new System.Drawing.Point(3, 68);
            this.AllUsersRichBox.Name = "AllUsersRichBox";
            this.AllUsersRichBox.Size = new System.Drawing.Size(1730, 616);
            this.AllUsersRichBox.TabIndex = 0;
            this.AllUsersRichBox.Text = "";
            this.AllUsersRichBox.TextChanged += new System.EventHandler(this.AllUsersRichBox_TextChanged);
            // 
            // ShowUsersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1731, 685);
            this.Controls.Add(this.AllUsersRichBox);
            this.Name = "ShowUsersInfo";
            this.Text = "ShowUsersInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowUsersInfo_FormClosing);
            this.Load += new System.EventHandler(this.ShowUsersInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AllUsersRichBox;
    }
}