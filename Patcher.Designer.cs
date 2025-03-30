namespace Better_Steam_Vr
{
    partial class Better_Steam_Patcher
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
            this.PatchingBar = new System.Windows.Forms.ProgressBar();
            this.quit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatchingBar
            // 
            this.PatchingBar.Location = new System.Drawing.Point(190, 370);
            this.PatchingBar.Margin = new System.Windows.Forms.Padding(4);
            this.PatchingBar.Maximum = 5;
            this.PatchingBar.Name = "PatchingBar";
            this.PatchingBar.Size = new System.Drawing.Size(430, 49);
            this.PatchingBar.TabIndex = 3;
            this.PatchingBar.Click += new System.EventHandler(this.PatchingBar_Click);
            // 
            // quit
            // 
            this.quit.AutoRoundedCorners = true;
            this.quit.BackColor = System.Drawing.Color.Red;
            this.quit.Cursor = System.Windows.Forms.Cursors.Default;
            this.quit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quit.FillColor = System.Drawing.Color.Red;
            this.quit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quit.ForeColor = System.Drawing.Color.Black;
            this.quit.Location = new System.Drawing.Point(850, -2);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(53, 45);
            this.quit.TabIndex = 4;
            this.quit.Text = "X";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 60F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(190, 136);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(430, 215);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Patch";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(1166, 1231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Better Steam VR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Better_Steam_Patcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(900, 554);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.PatchingBar);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Better_Steam_Patcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Steam Vr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar PatchingBar;
        private Guna.UI2.WinForms.Guna2Button quit;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}

