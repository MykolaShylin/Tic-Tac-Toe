using System.Runtime.CompilerServices;

namespace Tic_Tac_ToeWinFormsApp
{
    public partial class GameForm : Form
    {
        private string[,] _charsMap;
        private const int _mapSize = 3;
        private const string _charX = "X";
        private const string _charO = "O";
        private string _currentChar;
        private Random _random = new Random();
        public GameForm()
        {
            InitializeComponent();
            _charsMap = new string[_mapSize, _mapSize];
            var startingChar = _random.Next(2);
            if(startingChar == 0)
            {
                _currentChar = _charX;
            }
            else
            {
                _currentChar = _charO;
            }
        }
        private bool IsLabelClear(Label clickedLabel)
        {
            return clickedLabel.Text == string.Empty;
        }
        private bool IsGameOver(int key)
        {
            switch (key)
            {
                case 0: 
            
            }
        }
        private void leftLabel1_Click(object sender, EventArgs e)
        {
            if(IsLabelClear((Label)sender))
            {
                leftLabel1.Text = _currentChar;
                _charsMap[0, 0] = _currentChar;
            }
        }                
    }
}