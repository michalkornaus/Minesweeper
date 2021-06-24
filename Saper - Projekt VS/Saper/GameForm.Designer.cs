namespace Saper
{
    public partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Kod generowany przez Projektanta formularzy systemu Windows
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGry = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.wrocDoMenuLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelGry
            // 
            this.panelGry.Location = new System.Drawing.Point(13, 75);
            this.panelGry.Name = "panelGry";
            this.panelGry.Size = new System.Drawing.Size(429, 301);
            this.panelGry.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timerLabel.Location = new System.Drawing.Point(288, 13);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(110, 26);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "Czas: 00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrocDoMenuLabel
            // 
            this.wrocDoMenuLabel.AutoSize = true;
            this.wrocDoMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrocDoMenuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wrocDoMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrocDoMenuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wrocDoMenuLabel.Location = new System.Drawing.Point(13, 16);
            this.wrocDoMenuLabel.Name = "wrocDoMenuLabel";
            this.wrocDoMenuLabel.Size = new System.Drawing.Size(122, 18);
            this.wrocDoMenuLabel.TabIndex = 8;
            this.wrocDoMenuLabel.Text = "◄ Wróć do menu";
            this.wrocDoMenuLabel.Click += new System.EventHandler(this.WrocDoMenu_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerNameLabel.Location = new System.Drawing.Point(10, 522);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playerNameLabel.Size = new System.Drawing.Size(50, 18);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "Profil: ";
            this.playerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GameForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Saper.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 549);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.wrocDoMenuLabel);
            this.Controls.Add(this.panelGry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "Saper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gra_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panelGry;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label wrocDoMenuLabel;
        private System.Windows.Forms.Label playerNameLabel;
    }
}
