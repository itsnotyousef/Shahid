
namespace Shahid
{
    partial class AdminDeleteVideoForm
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
            this.VideoIdDeleteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Video ID";
            // 
            // VideoIdDeleteTextBox
            // 
            this.VideoIdDeleteTextBox.BackColor = System.Drawing.Color.Black;
            this.VideoIdDeleteTextBox.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoIdDeleteTextBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.VideoIdDeleteTextBox.Location = new System.Drawing.Point(492, 203);
            this.VideoIdDeleteTextBox.Name = "VideoIdDeleteTextBox";
            this.VideoIdDeleteTextBox.Size = new System.Drawing.Size(372, 46);
            this.VideoIdDeleteTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(49, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 113);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back To Admin Form ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deleting Video";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(492, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(401, 113);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete Video";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminDeleteVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(988, 618);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VideoIdDeleteTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AdminDeleteVideoForm";
            this.Text = "AdminDeleteVideoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDeleteVideoForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminDeleteVideoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VideoIdDeleteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}