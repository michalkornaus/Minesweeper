using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    [Serializable]
    public class Game
    {
        public string difficulty;
        public int playTime;
        public int minesCount;
        public int sizeRows;
        public int sizeColumns;
        public void CreateGame(int mines, int rows, int cols, string diff)
        {
            difficulty = diff;
            minesCount = mines;
            sizeRows = rows;
            sizeColumns = cols;
        }
    }
}
