namespace Saper
{
    partial class MenuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.wlasnaPlanszaBox = new System.Windows.Forms.GroupBox();
            this.licznikBomb = new System.Windows.Forms.NumericUpDown();
            this.bombyLabel = new System.Windows.Forms.Label();
            this.grajButton = new System.Windows.Forms.Button();
            this.licznikKolumn = new System.Windows.Forms.NumericUpDown();
            this.licznikWierszy = new System.Windows.Forms.NumericUpDown();
            this.kolumnyLabel = new System.Windows.Forms.Label();
            this.wierszeLabel = new System.Windows.Forms.Label();
            this.wyborTrudnosciBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.wrocMenuLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelRanking = new System.Windows.Forms.Panel();
            this.listViewRanking = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuSettingsButton = new System.Windows.Forms.Button();
            this.menuExitButton = new System.Windows.Forms.Button();
            this.menuPlayButton = new System.Windows.Forms.Button();
            this.menuLeaderboardButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPlayers = new System.Windows.Forms.Panel();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.editPlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currentPlayerLabel = new System.Windows.Forms.Label();
            this.panelNewPlayer = new System.Windows.Forms.Panel();
            this.exitPanel1Button = new System.Windows.Forms.Button();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEditPlayer = new System.Windows.Forms.Panel();
            this.exitPanel2Button = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wlasnaPlanszaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licznikBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikKolumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikWierszy)).BeginInit();
            this.wyborTrudnosciBox.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panelRanking.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelPlayers.SuspendLayout();
            this.panelNewPlayer.SuspendLayout();
            this.panelEditPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // wlasnaPlanszaBox
            // 
            this.wlasnaPlanszaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.wlasnaPlanszaBox.Controls.Add(this.licznikBomb);
            this.wlasnaPlanszaBox.Controls.Add(this.bombyLabel);
            this.wlasnaPlanszaBox.Controls.Add(this.grajButton);
            this.wlasnaPlanszaBox.Controls.Add(this.licznikKolumn);
            this.wlasnaPlanszaBox.Controls.Add(this.licznikWierszy);
            this.wlasnaPlanszaBox.Controls.Add(this.kolumnyLabel);
            this.wlasnaPlanszaBox.Controls.Add(this.wierszeLabel);
            resources.ApplyResources(this.wlasnaPlanszaBox, "wlasnaPlanszaBox");
            this.wlasnaPlanszaBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wlasnaPlanszaBox.Name = "wlasnaPlanszaBox";
            this.wlasnaPlanszaBox.TabStop = false;
            // 
            // licznikBomb
            // 
            this.licznikBomb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licznikBomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.licznikBomb, "licznikBomb");
            this.licznikBomb.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.licznikBomb.Name = "licznikBomb";
            this.licznikBomb.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // bombyLabel
            // 
            resources.ApplyResources(this.bombyLabel, "bombyLabel");
            this.bombyLabel.Name = "bombyLabel";
            // 
            // grajButton
            // 
            this.grajButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.grajButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.grajButton, "grajButton");
            this.grajButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.grajButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            this.grajButton.ForeColor = System.Drawing.Color.Azure;
            this.grajButton.Name = "grajButton";
            this.grajButton.UseVisualStyleBackColor = false;
            this.grajButton.Click += new System.EventHandler(this.CreateGame);
            // 
            // licznikKolumn
            // 
            this.licznikKolumn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licznikKolumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.licznikKolumn, "licznikKolumn");
            this.licznikKolumn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.licznikKolumn.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.licznikKolumn.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.licznikKolumn.Name = "licznikKolumn";
            this.licznikKolumn.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.licznikKolumn.ValueChanged += new System.EventHandler(this.licznikKolumn_ValueChanged);
            // 
            // licznikWierszy
            // 
            this.licznikWierszy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licznikWierszy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.licznikWierszy, "licznikWierszy");
            this.licznikWierszy.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.licznikWierszy.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.licznikWierszy.Name = "licznikWierszy";
            this.licznikWierszy.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.licznikWierszy.ValueChanged += new System.EventHandler(this.licznikWierszy_ValueChanged);
            // 
            // kolumnyLabel
            // 
            resources.ApplyResources(this.kolumnyLabel, "kolumnyLabel");
            this.kolumnyLabel.Name = "kolumnyLabel";
            // 
            // wierszeLabel
            // 
            resources.ApplyResources(this.wierszeLabel, "wierszeLabel");
            this.wierszeLabel.Name = "wierszeLabel";
            // 
            // wyborTrudnosciBox
            // 
            this.wyborTrudnosciBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.wyborTrudnosciBox.Controls.Add(this.button5);
            this.wyborTrudnosciBox.Controls.Add(this.button4);
            this.wyborTrudnosciBox.Controls.Add(this.button3);
            this.wyborTrudnosciBox.Controls.Add(this.button2);
            resources.ApplyResources(this.wyborTrudnosciBox, "wyborTrudnosciBox");
            this.wyborTrudnosciBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wyborTrudnosciBox.Name = "wyborTrudnosciBox";
            this.wyborTrudnosciBox.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.Azure;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.Azure;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.Azure;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.panelGame.Controls.Add(this.wrocMenuLabel);
            this.panelGame.Controls.Add(this.wyborTrudnosciBox);
            this.panelGame.Controls.Add(this.wlasnaPlanszaBox);
            resources.ApplyResources(this.panelGame, "panelGame");
            this.panelGame.Name = "panelGame";
            // 
            // wrocMenuLabel
            // 
            resources.ApplyResources(this.wrocMenuLabel, "wrocMenuLabel");
            this.wrocMenuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wrocMenuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wrocMenuLabel.Name = "wrocMenuLabel";
            this.wrocMenuLabel.Click += new System.EventHandler(this.wrocMenuLabel_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.panelRanking);
            this.mainPanel.Controls.Add(this.panelMenu);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.panelPlayers);
            this.mainPanel.Controls.Add(this.panelGame);
            this.mainPanel.Name = "mainPanel";
            // 
            // panelRanking
            // 
            this.panelRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.panelRanking.Controls.Add(this.listViewRanking);
            this.panelRanking.Controls.Add(this.label7);
            resources.ApplyResources(this.panelRanking, "panelRanking");
            this.panelRanking.Name = "panelRanking";
            // 
            // listViewRanking
            // 
            this.listViewRanking.AutoArrange = false;
            this.listViewRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.listViewRanking, "listViewRanking");
            this.listViewRanking.ForeColor = System.Drawing.Color.Azure;
            this.listViewRanking.FullRowSelect = true;
            this.listViewRanking.HideSelection = false;
            this.listViewRanking.MultiSelect = false;
            this.listViewRanking.Name = "listViewRanking";
            this.listViewRanking.TileSize = new System.Drawing.Size(15, 15);
            this.listViewRanking.UseCompatibleStateImageBehavior = false;
            this.listViewRanking.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.wrocMenuLabel_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.menuSettingsButton);
            this.panelMenu.Controls.Add(this.menuExitButton);
            this.panelMenu.Controls.Add(this.menuPlayButton);
            this.panelMenu.Controls.Add(this.menuLeaderboardButton);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.TabStop = true;
            // 
            // menuSettingsButton
            // 
            this.menuSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.menuSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuSettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.menuSettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.menuSettingsButton, "menuSettingsButton");
            this.menuSettingsButton.ForeColor = System.Drawing.Color.Azure;
            this.menuSettingsButton.Name = "menuSettingsButton";
            this.menuSettingsButton.UseVisualStyleBackColor = false;
            this.menuSettingsButton.Click += new System.EventHandler(this.PlayersMenuButton_Click);
            // 
            // menuExitButton
            // 
            this.menuExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.menuExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuExitButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.menuExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.menuExitButton, "menuExitButton");
            this.menuExitButton.ForeColor = System.Drawing.Color.Azure;
            this.menuExitButton.Name = "menuExitButton";
            this.menuExitButton.UseVisualStyleBackColor = false;
            this.menuExitButton.Click += new System.EventHandler(this.exitMenuButton_Click);
            // 
            // menuPlayButton
            // 
            this.menuPlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.menuPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPlayButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.menuPlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.menuPlayButton, "menuPlayButton");
            this.menuPlayButton.ForeColor = System.Drawing.Color.Azure;
            this.menuPlayButton.Name = "menuPlayButton";
            this.menuPlayButton.UseVisualStyleBackColor = false;
            this.menuPlayButton.Click += new System.EventHandler(this.menuPlayButton_Click);
            // 
            // menuLeaderboardButton
            // 
            this.menuLeaderboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.menuLeaderboardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLeaderboardButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.menuLeaderboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(122)))));
            resources.ApplyResources(this.menuLeaderboardButton, "menuLeaderboardButton");
            this.menuLeaderboardButton.ForeColor = System.Drawing.Color.Azure;
            this.menuLeaderboardButton.Name = "menuLeaderboardButton";
            this.menuLeaderboardButton.UseVisualStyleBackColor = false;
            this.menuLeaderboardButton.Click += new System.EventHandler(this.leaderboardMenuButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Name = "label3";
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.label3_Paint);
            // 
            // panelPlayers
            // 
            this.panelPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.panelPlayers.Controls.Add(this.listViewPlayers);
            this.panelPlayers.Controls.Add(this.removePlayerButton);
            this.panelPlayers.Controls.Add(this.editPlayerButton);
            this.panelPlayers.Controls.Add(this.addPlayerButton);
            this.panelPlayers.Controls.Add(this.label4);
            resources.ApplyResources(this.panelPlayers, "panelPlayers");
            this.panelPlayers.Name = "panelPlayers";
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.AutoArrange = false;
            this.listViewPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.listViewPlayers, "listViewPlayers");
            this.listViewPlayers.ForeColor = System.Drawing.Color.Azure;
            this.listViewPlayers.FullRowSelect = true;
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.MultiSelect = false;
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.ShowItemToolTips = true;
            this.listViewPlayers.TileSize = new System.Drawing.Size(15, 15);
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewPlayers_ColumnWidthChanging);
            this.listViewPlayers.ItemActivate += new System.EventHandler(this.listViewPlayers_Activate);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.removePlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.removePlayerButton, "removePlayerButton");
            this.removePlayerButton.ForeColor = System.Drawing.Color.Azure;
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.UseVisualStyleBackColor = false;
            this.removePlayerButton.Click += new System.EventHandler(this.removePlayerButton_Click);
            // 
            // editPlayerButton
            // 
            this.editPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.editPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.editPlayerButton, "editPlayerButton");
            this.editPlayerButton.ForeColor = System.Drawing.Color.Azure;
            this.editPlayerButton.Name = "editPlayerButton";
            this.editPlayerButton.UseVisualStyleBackColor = false;
            this.editPlayerButton.Click += new System.EventHandler(this.editPlayerButton_Click);
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.addPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.addPlayerButton, "addPlayerButton");
            this.addPlayerButton.ForeColor = System.Drawing.Color.Azure;
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.UseVisualStyleBackColor = false;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.wrocMenuLabel_Click);
            // 
            // currentPlayerLabel
            // 
            resources.ApplyResources(this.currentPlayerLabel, "currentPlayerLabel");
            this.currentPlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentPlayerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentPlayerLabel.Name = "currentPlayerLabel";
            // 
            // panelNewPlayer
            // 
            this.panelNewPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panelNewPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNewPlayer.CausesValidation = false;
            this.panelNewPlayer.Controls.Add(this.exitPanel1Button);
            this.panelNewPlayer.Controls.Add(this.createPlayerButton);
            this.panelNewPlayer.Controls.Add(this.label2);
            this.panelNewPlayer.Controls.Add(this.playerNameTextBox);
            this.panelNewPlayer.Controls.Add(this.label1);
            resources.ApplyResources(this.panelNewPlayer, "panelNewPlayer");
            this.panelNewPlayer.Name = "panelNewPlayer";
            // 
            // exitPanel1Button
            // 
            resources.ApplyResources(this.exitPanel1Button, "exitPanel1Button");
            this.exitPanel1Button.Name = "exitPanel1Button";
            this.exitPanel1Button.UseVisualStyleBackColor = true;
            this.exitPanel1Button.Click += new System.EventHandler(this.exitPanel1Button_Click);
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.createPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.createPlayerButton, "createPlayerButton");
            this.createPlayerButton.ForeColor = System.Drawing.Color.Azure;
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.UseVisualStyleBackColor = false;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.playerNameTextBox, "playerNameTextBox");
            this.playerNameTextBox.Name = "playerNameTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // panelEditPlayer
            // 
            this.panelEditPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.panelEditPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditPlayer.CausesValidation = false;
            this.panelEditPlayer.Controls.Add(this.exitPanel2Button);
            this.panelEditPlayer.Controls.Add(this.editButton);
            this.panelEditPlayer.Controls.Add(this.label5);
            this.panelEditPlayer.Controls.Add(this.textBox1);
            this.panelEditPlayer.Controls.Add(this.label6);
            resources.ApplyResources(this.panelEditPlayer, "panelEditPlayer");
            this.panelEditPlayer.Name = "panelEditPlayer";
            // 
            // exitPanel2Button
            // 
            resources.ApplyResources(this.exitPanel2Button, "exitPanel2Button");
            this.exitPanel2Button.Name = "exitPanel2Button";
            this.exitPanel2Button.UseVisualStyleBackColor = true;
            this.exitPanel2Button.Click += new System.EventHandler(this.exitPanel2Button_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            resources.ApplyResources(this.editButton, "editButton");
            this.editButton.ForeColor = System.Drawing.Color.Azure;
            this.editButton.Name = "editButton";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Saper.Properties.Resources.image;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelEditPlayer);
            this.Controls.Add(this.panelNewPlayer);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.currentPlayerLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MenuForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.MenuForm_Resize);
            this.wlasnaPlanszaBox.ResumeLayout(false);
            this.wlasnaPlanszaBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licznikBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikKolumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licznikWierszy)).EndInit();
            this.wyborTrudnosciBox.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panelRanking.ResumeLayout(false);
            this.panelRanking.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelPlayers.ResumeLayout(false);
            this.panelPlayers.PerformLayout();
            this.panelNewPlayer.ResumeLayout(false);
            this.panelNewPlayer.PerformLayout();
            this.panelEditPlayer.ResumeLayout(false);
            this.panelEditPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox wlasnaPlanszaBox;
        private System.Windows.Forms.NumericUpDown licznikKolumn;
        private System.Windows.Forms.NumericUpDown licznikWierszy;
        private System.Windows.Forms.Label kolumnyLabel;
        private System.Windows.Forms.Label wierszeLabel;
        private System.Windows.Forms.Button grajButton;
        private System.Windows.Forms.NumericUpDown licznikBomb;
        private System.Windows.Forms.Label bombyLabel;
        private System.Windows.Forms.GroupBox wyborTrudnosciBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button menuExitButton;
        private System.Windows.Forms.Button menuSettingsButton;
        private System.Windows.Forms.Button menuLeaderboardButton;
        private System.Windows.Forms.Button menuPlayButton;
        private System.Windows.Forms.Label wrocMenuLabel;
        private System.Windows.Forms.Label currentPlayerLabel;
        private System.Windows.Forms.Panel panelNewPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.Panel panelPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button editPlayerButton;
        private System.Windows.Forms.Button removePlayerButton;
        private System.Windows.Forms.Button exitPanel1Button;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.Panel panelEditPlayer;
        private System.Windows.Forms.Button exitPanel2Button;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelRanking;
        private System.Windows.Forms.ListView listViewRanking;
        private System.Windows.Forms.Label label7;
    }
}

