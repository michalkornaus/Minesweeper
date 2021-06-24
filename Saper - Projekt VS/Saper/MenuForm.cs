using System;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Saper
{
    public partial class MenuForm : Form
    {
        private List<Player> players;
        private Player currentPlayer;
        public MenuForm()
        {
            InitializeComponent();
            InitialConfiguration();
        }
        private void InitialConfiguration()
        {
            players = new List<Player>();
            InitGamePanelComponents();
            InitListView();
            ConfigPanels();
            ConfigButtons();
        }
        private void ConfigPanels()
        {
            ClientSize = new Size(mainPanel.Width + 100, mainPanel.Height + 80);
            //Ustawia wszystkie panele na jedną pozycję, aby gdy się je pokazuje i odkrywa są w tym samym miejscu
            mainPanel.Left = 50;
            panelMenu.Left = 5;
            panelMenu.Top = 64;
            panelPlayers.Left = 5;
            panelPlayers.Top = 64;
            panelRanking.Left = 5;
            panelRanking.Top = 64;
            mainPanel.Top = 15;
            panelNewPlayer.Top = 100;
            panelNewPlayer.Left = (Width / 2 - panelNewPlayer.Width / 2) - 6;
            panelEditPlayer.Top = 100;
            panelEditPlayer.Left = (Width / 2 - panelEditPlayer.Width / 2) - 6;
            panelEditPlayer.Hide();
            panelNewPlayer.Hide();
            panelPlayers.Hide();
            panelRanking.Hide();
            panelGame.Hide();
        }
        private void InitListView()
        {
            listViewPlayers.Columns.Add("Nazwa gracza", 220, HorizontalAlignment.Left);
            listViewPlayers.Columns.Add("Ilość wygranych gier", 200, HorizontalAlignment.Center);
            listViewRanking.Columns.Add("Gracz", 130, HorizontalAlignment.Left);
            listViewRanking.Columns.Add("Poziom trudności", 170, HorizontalAlignment.Center);
            listViewRanking.Columns.Add("Czas", 120, HorizontalAlignment.Left);
        }
        private void RefreshListView()
        {
            listViewPlayers.Items.Clear();
            ListViewItem[] items = new ListViewItem[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                string _name = players[i].name;
                int _games = players[i].gamesWon;
                items[i] = new ListViewItem(_name);
                items[i].SubItems.Add(_games.ToString());
                items[i].Font = new Font("Verdana", 12f, FontStyle.Regular);
                items[i].ToolTipText = "";
                if (currentPlayer == players[i])
                {
                    items[i].ToolTipText = "Aktualnie wybrany gracz";
                    items[i].Font = new Font("Verdana", 12f, FontStyle.Bold);
                }
            }
            listViewPlayers.Items.AddRange(items);
        }
        private void RefreshLeaderboard()
        {
            listViewRanking.Items.Clear();
            for (int i = 0; i < players.Count; i++)
            {
                ListViewItem[] games = new ListViewItem[validGames(players[i])];
                for (int j = 0; j < players[i].games.Count; j++)
                {
                    if (players[i].games[j].difficulty != "-")
                    {
                        if (j == 0)
                            games[j] = new ListViewItem(players[i].name);
                        else
                            games[j] = new ListViewItem("  - ");

                        TimeSpan time = TimeSpan.FromSeconds(players[i].games[j].playTime);
                        string str = time.ToString(@"mm\:ss");
                        games[j].SubItems.Add(players[i].games[j].difficulty);
                        games[j].SubItems.Add(str);
                    }
                }
                listViewRanking.Items.AddRange(games);
            }
        }
        private int validGames(Player player)
        {
            int sum = 0;
            foreach (var game in player.games)
            {
                if (game.difficulty != "-")
                    sum++;
            }
            return sum;
        }
        private void ConfigButtons()
        {
            byte[] bytes = { 240, 159, 146, 163 };
            char c = '\u2691';
            menuPlayButton.Left = (panelMenu.Width / 2) - (menuPlayButton.Width / 2);
            menuPlayButton.Text = c.ToString() + " Graj";
            menuSettingsButton.Left = (panelMenu.Width / 2) - (menuSettingsButton.Width / 2);
            menuLeaderboardButton.Left = (panelMenu.Width / 2) - (menuLeaderboardButton.Width / 2);
            menuExitButton.Left = (panelMenu.Width / 2) - (menuExitButton.Width / 2);
            menuExitButton.Text = Encoding.UTF8.GetString(bytes) + " Wyjdź";
        }
        private void InitGamePanelComponents()
        {
            licznikBomb.Maximum = Math.Round((licznikKolumn.Value * licznikWierszy.Value) / 3, MidpointRounding.ToEven);
            button2.Click += delegate (object sender, EventArgs e) //Łatwy - 10 bomb
            { StartNewGame(sender, e, 12, 12, 10, "Łatwy"); };
            button3.Click += delegate (object sender, EventArgs e) //Średni - 30 bomb
            { StartNewGame(sender, e, 15, 15, 30, "Średni"); };
            button4.Click += delegate (object sender, EventArgs e) //Trudny - 50 bomb
            { StartNewGame(sender, e, 20, 20, 50, "Trudny"); };
            button5.Click += delegate (object sender, EventArgs e) //Extremalny - 75 bomb
            { StartNewGame(sender, e, 25, 25, 75, "Extremalny"); };
        }
        private void CreateGame(object sender, EventArgs e)
        {
            string message = String.Format("Utworzyć plansze o wielkości {0} na {1}?", licznikWierszy.Value, licznikKolumn.Value);
            string caption = "Plansza Sapera";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                CreateOwnGame();
            }
        }
        private void StartNewGame(object sender, EventArgs e, int wiersze, int kolumny, int bomby, string diff)
        {
            Hide();
            GameForm game = new GameForm(kolumny, wiersze, bomby, diff, currentPlayer);
            game.Show(this);
        }
        private void CreateOwnGame()
        {
            Hide();
            GameForm game = new GameForm((int)licznikKolumn.Value, (int)licznikWierszy.Value, (int)licznikBomb.Value, "-", currentPlayer);
            game.Show(this);
        }
        private void licznikKolumn_ValueChanged(object sender, EventArgs e)
        {
            licznikBomb.Maximum = Math.Round((licznikKolumn.Value * licznikWierszy.Value) / 3, MidpointRounding.ToEven);
        }
        private void licznikWierszy_ValueChanged(object sender, EventArgs e)
        {
            licznikBomb.Maximum = Math.Round((licznikKolumn.Value * licznikWierszy.Value) / 3, MidpointRounding.ToEven);
        }
        private void menuPlayButton_Click(object sender, EventArgs e)
        {
            if (players.Count == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show("Nie ma żadnego utworzonego gracza.\nCzy chcesz utworzyć nowego gracza?", "Utwórz gracza", buttons);
                if (result == DialogResult.OK)
                {
                    label3.Text = "Lista graczy";
                    panelMenu.Hide();
                    panelPlayers.Show();
                }
            }
            else
            {
                label3.Text = "Rozpocznij grę";
                panelMenu.Hide();
                panelGame.Show();
            }
        }
        private void PlayersMenuButton_Click(object sender, EventArgs e)
        {
            label3.Text = "Lista graczy";
            panelMenu.Hide();
            panelPlayers.Show();
        }
        private void leaderboardMenuButton_Click(object sender, EventArgs e)
        {
            if (players.Count == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show("Nie ma żadnego utworzonego gracza.\nCzy chcesz utworzyć nowego gracza?", "Utwórz gracza", buttons);
                if (result == DialogResult.OK)
                {
                    label3.Text = "Lista graczy";
                    panelMenu.Hide();
                    panelPlayers.Show();
                }
            }
            else
            {
                label3.Text = "Ranking wyników";
                panelMenu.Hide();
                panelRanking.Show();
            }
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = String.Format("Czy chcesz zakończyć grę?");
            string caption = "Zakończenie gry";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                SavePlayerData();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void SavePlayerData()
        {
            if (players.Count > 0)
            {
                using (StreamWriter writer = new StreamWriter("gracze.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                    xs.Serialize(writer, players);
                }
            }
        }
        private void wrocMenuLabel_Click(object sender, EventArgs e)
        {
            label3.Text = "Saper";
            panelMenu.Show();
            panelGame.Hide();
            panelPlayers.Hide();
            panelRanking.Hide();
        }
        private bool isNameTaken(string name)
        {
            foreach (var player in players)
            {
                if (player.name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void createPlayerButton_Click(object sender, EventArgs e)
        {
            if (playerNameTextBox.Text.Length >= 3 && playerNameTextBox.Text != "")
            {
                if (!isNameTaken(playerNameTextBox.Text))
                {
                    Player _player = new Player(); //Tymczasowo tworzymy nowego gracza i przypisujemy do lokalnego obecnego gracza
                    _player.name = playerNameTextBox.Lines[0];
                    playerNameTextBox.Text = "";

                    ListViewItem item = new ListViewItem(_player.name, 0);
                    item.SubItems.Add(_player.gamesWon.ToString());
                    listViewPlayers.Items.Add(item);

                    _player.CreatePlayer();
                    players.Add(_player);

                    if (players.Count == 1)
                    {
                        currentPlayer = _player;
                        currentPlayerLabel.Text = "Obecnie wybrany gracz: " + _player.name;
                    }

                    panelNewPlayer.Hide();
                    RefreshListView();
                    SavePlayerData();
                }
                else
                {
                    MessageBox.Show("Nazwa gracza jest już zajęta", "Wpisz poprawną nazwę", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nazwa gracza powinna być dłuższa niż 2 znaki", "Wpisz poprawną nazwę", MessageBoxButtons.OK);
            }
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.bomb;
            if (File.Exists("gracze.xml"))
            {
                using (StreamReader reader = new StreamReader("gracze.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Player>));
                    players = (List<Player>)xs.Deserialize(reader);
                }
                currentPlayer = players[0];
                currentPlayerLabel.Text = "Obecnie wybrany gracz: " + currentPlayer.name;
                RefreshListView();
                RefreshLeaderboard();
            }
        }
        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count > 0)
            {
                string caption = "Usunięcie gracza";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                int _index = listViewPlayers.FocusedItem.Index;
                result = MessageBox.Show("Czy chcesz usunąć gracza " + players[_index].name + "?", caption, buttons);
                if (result == DialogResult.Yes)
                {
                    listViewPlayers.Items.RemoveAt(_index);
                    if (players[_index] == currentPlayer)
                    {
                        if (players.Count > 1)
                        {
                            players.RemoveAt(_index);
                            currentPlayer = players[0];
                            currentPlayerLabel.Text = "Obecnie wybrany gracz: " + currentPlayer.name;
                        }
                        else
                        {
                            players.RemoveAt(_index);
                        }
                    }
                    else
                    {
                        players.RemoveAt(_index);
                    }
                    if (players.Count == 0)
                    {
                        currentPlayerLabel.Text = "Obecnie wybrany gracz: Brak graczy";
                        File.Delete("gracze.xml");
                        return;
                    }
                    RefreshListView();
                    SavePlayerData();
                }
            }
        }
        private void listViewPlayers_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = ((ListView)sender).Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        private void label3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, SystemColors.GradientActiveCaption, ButtonBorderStyle.Solid);
        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            panelNewPlayer.Show();
        }
        private void exitPanel1Button_Click(object sender, EventArgs e)
        {
            panelNewPlayer.Hide();
        }
        private void exitMenuButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MenuForm_VisibleChanged(object sender, EventArgs e)
        {
            SavePlayerData();
            RefreshLeaderboard();
            RefreshListView();
        }
        private void exitPanel2Button_Click(object sender, EventArgs e)
        {
            panelEditPlayer.Hide();
        }
        private void editPlayerButton_Click(object sender, EventArgs e)
        {
            if (listViewPlayers.SelectedItems.Count > 0)
            {
                textBox1.Text = players[listViewPlayers.FocusedItem.Index].name;
                panelEditPlayer.Show();
            }
        }
        private void listViewPlayers_Activate(object sender, EventArgs e)
        {
            int _index = listViewPlayers.FocusedItem.Index;
            currentPlayer = players[_index];
            currentPlayerLabel.Text = "Obecnie wybrany gracz: " + currentPlayer.name;
            RefreshListView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3 && textBox1.Text != "")
            {
                if (!isNameTaken(textBox1.Text))
                {
                    string _name = textBox1.Lines[0];
                    int _index = listViewPlayers.FocusedItem.Index;
                    Player _player = players[_index];
                    textBox1.Text = "";
                    listViewPlayers.Items[_index].Text = _name;
                    _player.name = _name;
                    panelEditPlayer.Hide();
                    currentPlayerLabel.Text = "Obecnie wybrany gracz: " + currentPlayer.name;
                    SavePlayerData();
                }
                else
                {
                    MessageBox.Show("Nazwa gracza jest już zajęta", "Wpisz poprawną nazwę", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Nazwa gracza powinna być dłuższa niż 2 znaki", "Wpisz poprawną nazwę", MessageBoxButtons.OK);
            }
        }

        private void MenuForm_Resize(object sender, EventArgs e)
        {
            mainPanel.Left = Width / 2 - mainPanel.Width / 2;
        }
    }
}
