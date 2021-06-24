using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Saper
{
    public class Cell: Label
    {
        private Color kolor;

        public bool czyMina;   
        public bool zaznaczone;
        public bool czyOtwarte;
        public int pozX;
        public int pozY;
        public Cell()
        {
            GenerujPole();
        }
        public void GenerujPole()
        {
            czyMina = false;
            czyOtwarte = false;
            zaznaczone = false;
        }
        public void ZwrocKolorPola(int a)
        {
            switch (a)
            {
                case 1:
                    kolor = Color.FromArgb(45, 112, 214);
                    break;
                case 2:
                    kolor = Color.ForestGreen;
                    break;
                case 3:
                    kolor = Color.Red;
                    break;
                case 4:
                    kolor = Color.MediumPurple;
                    break;
                case 5:
                    kolor = Color.DarkRed;
                    break;
                case 6:
                    kolor = Color.DarkCyan;
                    break;
                case 7:
                    kolor = Color.Purple;
                    break;
                case 8:
                    kolor = Color.Gray;
                    break;
                default:
                    kolor = Color.DarkGray;
                    break;
            }
            ForeColor = kolor;
        }
    }
}
