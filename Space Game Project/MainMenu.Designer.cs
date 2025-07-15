namespace Space_Game_Project
{
    partial class MainMenu
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
            this.gameName = new System.Windows.Forms.Label();
            this.Playbtn = new System.Windows.Forms.Button();
            this.Customisebtn = new System.Windows.Forms.Button();
            this.Settingbtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.BackColor = System.Drawing.Color.Black;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.Red;
            this.gameName.Location = new System.Drawing.Point(166, 99);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(296, 55);
            this.gameName.TabIndex = 0;
            this.gameName.Text = "Space Wars";
            // 
            // Playbtn
            // 
            this.Playbtn.BackColor = System.Drawing.Color.Transparent;
            this.Playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Playbtn.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playbtn.ForeColor = System.Drawing.Color.Cyan;
            this.Playbtn.Location = new System.Drawing.Point(225, 191);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(189, 49);
            this.Playbtn.TabIndex = 1;
            this.Playbtn.Text = "PLAY";
            this.Playbtn.UseVisualStyleBackColor = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // Customisebtn
            // 
            this.Customisebtn.BackColor = System.Drawing.Color.Transparent;
            this.Customisebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customisebtn.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customisebtn.ForeColor = System.Drawing.Color.Cyan;
            this.Customisebtn.Location = new System.Drawing.Point(208, 271);
            this.Customisebtn.Name = "Customisebtn";
            this.Customisebtn.Size = new System.Drawing.Size(237, 51);
            this.Customisebtn.TabIndex = 2;
            this.Customisebtn.Text = "Customise Ship";
            this.Customisebtn.UseVisualStyleBackColor = false;
            this.Customisebtn.Click += new System.EventHandler(this.Customisebtn_Click);
            // 
            // Settingbtn
            // 
            this.Settingbtn.BackColor = System.Drawing.Color.Transparent;
            this.Settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingbtn.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settingbtn.ForeColor = System.Drawing.Color.Cyan;
            this.Settingbtn.Location = new System.Drawing.Point(225, 350);
            this.Settingbtn.Name = "Settingbtn";
            this.Settingbtn.Size = new System.Drawing.Size(189, 51);
            this.Settingbtn.TabIndex = 3;
            this.Settingbtn.Text = "Settings";
            this.Settingbtn.UseVisualStyleBackColor = false;
            this.Settingbtn.Click += new System.EventHandler(this.Settingbtn_Click);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.Transparent;
            this.Quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quitbtn.Font = new System.Drawing.Font("Impact", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.ForeColor = System.Drawing.Color.Cyan;
            this.Quitbtn.Location = new System.Drawing.Point(225, 434);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(189, 50);
            this.Quitbtn.TabIndex = 4;
            this.Quitbtn.Text = "Quit";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 595);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.Settingbtn);
            this.Controls.Add(this.Customisebtn);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.gameName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button Customisebtn;
        private System.Windows.Forms.Button Settingbtn;
        private System.Windows.Forms.Button Quitbtn;
    }
}