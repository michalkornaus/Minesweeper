using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Saper
{
    public partial class GameForm : Form
    {
        private DateTime time = new DateTime();
        private Random randomNumber = new Random(DateTime.Now.Millisecond);
        private Player currentPlayer;
        private Cell[,] tabCells;
        private int secondsFromStart;
        private int cellSize = 40;
        private float fontSize = 15;
        private int MinesCount;
        private int columns;
        private int rows;
        private int selectedMinesCount;
        private int hiddenCellsCount;
        private bool minesGenerated = false;
        private string difficulty;
        public GameForm(int _cols, int _rows, int bombs, string diff, Player player)
        {
            Icon = Properties.Resources.bomb;
            InitializeComponent();
            difficulty = diff;
            currentPlayer = player;
            MinesCount = bombs;
            hiddenCellsCount = _cols * _rows;
            columns = _cols;
            rows = _rows;
            cellSize = cellSize - Math.Max(columns, rows) / 2;
            fontSize = fontSize - Math.Max(columns, rows) / 7;
            InitialConfig();
        }
        private void InitialConfig()
        {
            CreateFields();
            SetElements();
            playerNameLabel.Text = "Profil: " + currentPlayer.name;
            SoundPlayer sound = new SoundPlayer(Properties.Resources.startGame);
            sound.Play();
        }
        private int CountNearMines(int k, int l)
        {
            int count = 0;
            for (int i = k - 1; i <= k + 1; i++)
            {
                for (int j = l - 1; j <= l + 1; j++)
                {
                    if (i >= 0 && i < columns && j >= 0 && j < rows)
                        if (tabCells[i, j].czyMina)
                            count++;
                }
            }
            return count;
        }
        private void CreateFields()
        {
            tabCells = new Cell[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    tabCells[i, j] = new Cell
                    {
                        Size = new Size(cellSize - 2, cellSize - 2),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Tahoma", fontSize, FontStyle.Regular),
                        BackColor = Color.FromArgb(102, 161, 225),
                        TabIndex = 2,
                        pozX = i,
                        pozY = j,
                        Location = new Point(cellSize * i, cellSize * j)
                    };
                    tabCells[i, j].MouseClick += new MouseEventHandler(FieldClick);
                    panelGry.Controls.Add(tabCells[i, j]);
                }
            }
            panelGry.Size = new Size((cellSize * columns) - 3, (cellSize * rows) - 3);
            panelGry.BackColor = Color.FromArgb(43, 48, 54);
            ClientSize = new Size(cellSize * columns + 100, cellSize * rows + 100);
        }
        private void GenerateMines(int x, int y)
        {
            int i = MinesCount;
            while (i > 0)
            {
                int randX = randomNumber.Next(0, columns);
                int randY = randomNumber.Next(0, rows);
                if (!(x - 1 <= randX && x + 1 >= randX && y - 1 <= randY && y + 1 >= randY) && !tabCells[randX, randY].czyMina)
                {
                    i -= 1;
                    tabCells[randX, randY].czyMina = true;
                }
            }
            minesGenerated = true;
        }
        private void ShowRemainingMines()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (tabCells[i, j].czyMina)
                    {
                        byte[] bytes = { 240, 159, 146, 163 };
                        tabCells[i, j].BackColor = Color.PaleVioletRed;
                        tabCells[i, j].Text = Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
        private void _ShowRemainingMines()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (tabCells[i, j].czyMina)
                    {
                        byte[] bytes = { 240, 159, 146, 163 };
                        tabCells[i, j].BackColor = Color.FromArgb(80, 141, 206);
                        tabCells[i, j].Text = Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }
        private void SetElements()
        {
            panelGry.Left = ((Width - panelGry.Width) / 2) - 8;
            panelGry.Top = 60;
            timerLabel.Left = ((Width - timerLabel.Width) / 2) - 8;
            timerLabel.Top = 15;
            panelGry.Show();
            timerLabel.Show();
        }

        private bool isPointValid(int x, int y)
        {
            if (x >= 0 && x <= columns - 1 && y >= 0 && y <= rows - 1)
                return true;
            else return false;
        }
        private void CheckCell(int x, int y)
        {
            if (isPointValid(x, y) == false) return;
            if (tabCells[x, y].czyOtwarte) return;
            tabCells[x, y].Refresh();
            tabCells[x, y].BackColor = Color.FromArgb(225, 225, 245);
            if (CountNearMines(x, y) == 0)
            {
                hiddenCellsCount--;
                tabCells[x, y].czyOtwarte = true;
                tabCells[x, y].Refresh();
                CheckNearFields(x, y);
            }
            else if (CountNearMines(x, y) > 0)
            {
                hiddenCellsCount--;
                tabCells[x, y].czyOtwarte = true;
                tabCells[x, y].Text = CountNearMines(x, y).ToString();
                tabCells[x, y].ZwrocKolorPola(CountNearMines(x, y));
                tabCells[x, y].Refresh();
            }
        }
        private void CheckNearFields(int x, int y)
        {
            CheckCell(x - 1, y - 1);
            CheckCell(x - 1, y);
            CheckCell(x - 1, y + 1);
            CheckCell(x + 1, y);
            CheckCell(x, y - 1);
            CheckCell(x, y + 1);
            CheckCell(x + 1, y - 1);
            CheckCell(x + 1, y + 1);
        }
        private void FieldClick(object sender, MouseEventArgs e)
        {
            Cell cell = sender as Cell;
            int wiersz = cell.pozX;
            int kolumn = cell.pozY;
            if (!minesGenerated)
            {
                GenerateMines(wiersz, kolumn);
                selectedMinesCount = 0;
                secondsFromStart = 0;
                timer1.Start();
            }
            if (e.Button == MouseButtons.Left)
            {
                if (!tabCells[wiersz, kolumn].zaznaczone)
                {
                    if (!tabCells[wiersz, kolumn].czyOtwarte)
                    {
                        tabCells[wiersz, kolumn].czyOtwarte = true;
                        if (tabCells[wiersz, kolumn].czyMina)
                        {
                            LoseGame();
                            return;
                        }
                        if (CountNearMines(wiersz, kolumn) == 0)
                        {
                            hiddenCellsCount--;
                            CheckNearFields(wiersz, kolumn);
                            cell.BackColor = Color.FromArgb(225, 225, 245);
                            cell.Refresh();
                        }
                        else if (CountNearMines(wiersz, kolumn) > 0)
                        {
                            hiddenCellsCount--;
                            cell.Text = CountNearMines(wiersz, kolumn).ToString();
                            cell.BackColor = Color.FromArgb(225, 225, 245);
                            cell.ZwrocKolorPola(CountNearMines(wiersz, kolumn));
                            cell.Refresh();
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (!tabCells[wiersz, kolumn].czyOtwarte)
                {
                    tabCells[wiersz, kolumn].zaznaczone = !tabCells[wiersz, kolumn].zaznaczone;
                    if (tabCells[wiersz, kolumn].zaznaczone)
                    {
                        cell.Refresh();
                        cell.BackColor = Color.FromArgb(80, 141, 206);
                        char c = '\u2691';
                        cell.Text = c.ToString();
                        if (tabCells[wiersz, kolumn].czyMina)
                        {
                            selectedMinesCount++;
                        }
                        else
                        {
                            selectedMinesCount--;
                        }
                    }
                    else
                    {
                        cell.BackColor = Color.FromArgb(102, 161, 225);
                        cell.Text = "";
                        if (tabCells[wiersz, kolumn].czyMina)
                        {
                            selectedMinesCount--;
                        }
                        else
                        {
                            selectedMinesCount++;
                        }
                    }
                }
                if (selectedMinesCount == MinesCount)
                {
                    WinGame();
                    return;
                }
            }
            if (hiddenCellsCount == MinesCount)
            {
                _ShowRemainingMines();
                WinGame();
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsFromStart++;
            time = time.AddSeconds(1);
            String timer = "Czas: " + time.ToString("mm:ss");
            timerLabel.Text = timer;
        }

        private void LoseGame()
        {
            timer1.Stop();
            ShowRemainingMines();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.loseGame);
            sound.Play();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (MessageBox.Show("Wpadłeś na minę! \nPrzegrałeś tę rozgrywkę, możesz \nspróbować wygrać kolejną!", "Przegrałeś", buttons) == DialogResult.OK)
            {
                Owner.Show();
                Dispose();
            }
        }

        private void WinGame()
        {
            timer1.Stop();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.winGame);
            sound.Play();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (MessageBox.Show("Brawo, znalazłeś wszystkie bomby!\nCzy chcesz dodać wynik do tablicy wyników?", "Wygrałeś", buttons) == DialogResult.Yes)
            {
                currentPlayer.NewGame(MinesCount, columns, rows, difficulty);
                currentPlayer.GameWon(secondsFromStart);
                Owner.Show();
                Dispose();
            }
            else
            {
                Owner.Show();
                Dispose();
            }
        }

        private void WrocDoMenu_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Czy chcesz wrócić do menu i utracić swój postęp?", "Wróć do menu", buttons);
            if (result == DialogResult.Yes)
            {
                Owner.Show();
                Dispose();
            }
        }
        private void Gra_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show("Czy chcesz wrócić do menu i utracić swój postęp?", "Wróć do menu", buttons);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                Owner.Show();
                Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
