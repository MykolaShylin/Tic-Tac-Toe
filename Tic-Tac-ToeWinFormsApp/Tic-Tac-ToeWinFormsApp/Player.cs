using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_ToeWinFormsApp
{
    public class Player
    {
        public string Name { get; }

        private int _CountMoves = 1;
        public string GameChar { get; }
        public Player(string name, string gameChar)
        { 
            Name = name;
            GameChar = gameChar;
        }

        public void AddMove()
        {
            _CountMoves++;
        }

        public int GetMovesCount()
        { 
            return _CountMoves; 
        }

        public void ResetMoves()
        {
            _CountMoves = 0;
        }
    }
}
