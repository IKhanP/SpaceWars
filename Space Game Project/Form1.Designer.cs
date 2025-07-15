namespace Space_Game_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.wave_timer = new System.Windows.Forms.Timer(this.components);
            this.countdownlbl = new System.Windows.Forms.Label();
            this.playerhitbox = new System.Windows.Forms.PictureBox();
            this.Scorelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerhitbox)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackgroundImage = global::Space_Game_Project.Properties.Resources.ship5;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Location = new System.Drawing.Point(270, 249);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(77, 73);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_event);
            // 
            // wave_timer
            // 
            this.wave_timer.Enabled = true;
            this.wave_timer.Interval = 1000;
            this.wave_timer.Tick += new System.EventHandler(this.wave_timer_event);
            // 
            // countdownlbl
            // 
            this.countdownlbl.AutoSize = true;
            this.countdownlbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlbl.Location = new System.Drawing.Point(13, 13);
            this.countdownlbl.Name = "countdownlbl";
            this.countdownlbl.Size = new System.Drawing.Size(173, 34);
            this.countdownlbl.TabIndex = 1;
            this.countdownlbl.Text = "Next wave: 10";
            // 
            // playerhitbox
            // 
            this.playerhitbox.BackColor = System.Drawing.Color.Transparent;
            this.playerhitbox.Location = new System.Drawing.Point(284, 266);
            this.playerhitbox.Name = "playerhitbox";
            this.playerhitbox.Size = new System.Drawing.Size(52, 44);
            this.playerhitbox.TabIndex = 2;
            this.playerhitbox.TabStop = false;
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelbl.Location = new System.Drawing.Point(497, 13);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(91, 34);
            this.Scorelbl.TabIndex = 3;
            this.Scorelbl.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 595);
            this.Controls.Add(this.Scorelbl);
            this.Controls.Add(this.playerhitbox);
            this.Controls.Add(this.countdownlbl);
            this.Controls.Add(this.player);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MouseIsClicked);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_move);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerhitbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer wave_timer;
        private System.Windows.Forms.Label countdownlbl;
        private System.Windows.Forms.PictureBox playerhitbox;
        private System.Windows.Forms.Label Scorelbl;
    }
}

