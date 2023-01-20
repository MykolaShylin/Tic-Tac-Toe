using System.Runtime.CompilerServices;

namespace Tic_Tac_ToeWinFormsApp
{
    public partial class GameForm : Form
    {
        private Label[,] _labels;
        private const int _mapSize = 3;
        private string _currentChar;
        private Player player1;
        private Player player2;
        private Random _random = new Random();
        public GameForm(Player player1, Player player2)
        {
            InitializeComponent();
            this.player1 = player1;
            this.player2 = player2;
            nameLabel1.Text = player1.Name;
            nameLabel2.Text = player2.Name;
            playerCharLabel1.Text = player1.GameChar;
            playerCharLabel2.Text = player2.GameChar;
            _labels = new Label[_mapSize, _mapSize];
            _labels[0, 0] = Label0;
            _labels[0, 1] = Label1;
            _labels[0, 2] = Label2;
            _labels[1, 0] = Label3;
            _labels[1, 1] = Label4;
            _labels[1, 2] = Label5;
            _labels[2, 0] = Label6;
            _labels[2, 1] = Label7;
            _labels[2, 2] = Label8;
            SelectFirstMoveChar();
        }
        private void SelectFirstMoveChar()
        {
            var rand = _random.Next(0, 2);
            if (rand == 0)
            {
                _currentChar = player1.GameChar;
                playerCharLabel1.BackColor = Color.PaleGreen;
                playerCharLabel2.BackColor = Color.Transparent;
            }
            else
            {
                _currentChar = player2.GameChar;
                playerCharLabel2.BackColor = Color.PaleGreen;
                playerCharLabel1.BackColor = Color.Transparent;
            }

        }
        private void IsGameOver(int key)
        {
            bool gameOver = false;
            switch (key)
            {
                case 0:
                    gameOver = _labels[0, 0].Text == _currentChar && _labels[0, 1].Text == _currentChar && _labels[0, 2].Text == _currentChar ||
                        _labels[0, 0].Text == _currentChar && _labels[1, 0].Text == _currentChar && _labels[2, 0].Text == _currentChar ||
                        _labels[0, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 2].Text == _currentChar;
                    break;
                case 1:
                    gameOver = _labels[0, 0].Text == _currentChar && _labels[0, 1].Text == _currentChar && _labels[0, 2].Text == _currentChar ||
                        _labels[0, 1].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 1].Text == _currentChar;
                    break;
                case 2:
                    gameOver = _labels[0, 0].Text == _currentChar && _labels[0, 1].Text == _currentChar && _labels[0, 2].Text == _currentChar ||
                        _labels[0, 2].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 0].Text == _currentChar ||
                        _labels[0, 2].Text == _currentChar && _labels[1, 2].Text == _currentChar && _labels[2, 2].Text == _currentChar;
                    break;
                case 3:
                    gameOver = _labels[0, 0].Text == _currentChar && _labels[0, 1].Text == _currentChar && _labels[0, 2].Text == _currentChar ||
                        _labels[1, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[1, 2].Text == _currentChar;
                    break;
                case 4:
                    gameOver = _labels[0, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 2].Text == _currentChar ||
                        _labels[0, 2].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 0].Text == _currentChar ||
                        _labels[0, 1].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 1].Text == _currentChar ||
                        _labels[1, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[1, 2].Text == _currentChar;
                    break;
                case 5:
                    gameOver = _labels[0, 2].Text == _currentChar && _labels[1, 2].Text == _currentChar && _labels[2, 2].Text == _currentChar ||
                        _labels[1, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[1, 2].Text == _currentChar;
                    break;
                case 6:
                    gameOver = _labels[2, 0].Text == _currentChar && _labels[2, 1].Text == _currentChar && _labels[2, 2].Text == _currentChar ||
                        _labels[0, 0].Text == _currentChar && _labels[1, 0].Text == _currentChar && _labels[2, 0].Text == _currentChar ||
                        _labels[2, 0].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[0, 2].Text == _currentChar;
                    break;
                case 7:
                    gameOver = _labels[2, 0].Text == _currentChar && _labels[2, 1].Text == _currentChar && _labels[2, 2].Text == _currentChar ||
                        _labels[0, 1].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[2, 1].Text == _currentChar;
                    break;
                case 8:
                    gameOver = _labels[2, 0].Text == _currentChar && _labels[2, 1].Text == _currentChar && _labels[2, 2].Text == _currentChar ||
                        _labels[2, 2].Text == _currentChar && _labels[1, 1].Text == _currentChar && _labels[0, 0].Text == _currentChar ||
                        _labels[0, 2].Text == _currentChar && _labels[1, 2].Text == _currentChar && _labels[2, 2].Text == _currentChar;
                    break;
            }
            if (!gameOver)
            {
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (_labels[i, j].Enabled)
                        {
                            return;
                        }
                    }
                }
                EndGame(false);
            }
            else
            {
                EndGame(true);
            }
            return;
        }
        private void Label0_Click(object sender, EventArgs e)
        {

            Label0.Text = _currentChar;
            Label0.Enabled = false;
            IsGameOver(0);
            ChangeChar();
        }
        private void Label1_Click(object sender, EventArgs e)
        {
            Label1.Text = _currentChar;
            Label1.Enabled = false;
            IsGameOver(1);
            ChangeChar();
        }
        private void Label2_Click(object sender, EventArgs e)
        {
            Label2.Text = _currentChar;
            Label2.Enabled = false;
            IsGameOver(2);
            ChangeChar();
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            Label3.Text = _currentChar;
            Label3.Enabled = false;
            IsGameOver(3);
            ChangeChar();
        }
        private void Label4_Click(object sender, EventArgs e)
        {
            Label4.Text = _currentChar;
            Label4.Enabled = false;
            IsGameOver(4);
            ChangeChar();
        }
        private void Label5_Click(object sender, EventArgs e)
        {
            Label5.Text = _currentChar;
            Label5.Enabled = false;
            IsGameOver(5);
            ChangeChar();
        }
        private void Label6_Click(object sender, EventArgs e)
        {
            Label6.Text = _currentChar;
            Label6.Enabled = false;
            IsGameOver(6);
            ChangeChar();
        }
        private void Label7_Click(object sender, EventArgs e)
        {
            Label7.Text = _currentChar;
            Label7.Enabled = false;
            IsGameOver(7);
            ChangeChar();
        }
        private void Label8_Click(object sender, EventArgs e)
        {
            Label8.Text = _currentChar;
            Label8.Enabled = false;
            IsGameOver(8);
            ChangeChar();
        }
        private void ChangeChar()
        {
            if (_currentChar == player1.GameChar)
            {
                player1.AddMove();
                _currentChar = player2.GameChar;
            }
            else
            {
                player2.AddMove();
                _currentChar = player1.GameChar;
            }
            var temp = playerCharLabel1.BackColor;
            playerCharLabel1.BackColor = playerCharLabel2.BackColor;
            playerCharLabel2.BackColor = temp;

        }
        private void EndGame(bool isSomeBodyWinner)
        {
            if (isSomeBodyWinner)
            {
                if (_currentChar == player1.GameChar)
                {
                    MessageBox.Show($"Поздравляем {player2.Name}, вы победили сделав {player2.GetMovesCount()} хода(-ов)", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Поздравляем {player1.Name}, вы победили сделав {player1.GetMovesCount()} хода(-ов)", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                foreach (var label in _labels)
                {
                    label.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("На этот раз ничья, попробуйте снова!", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (var label in _labels)
            {
                label.Text = string.Empty;
                label.Enabled = true;
            }
            player1.ResetMoves();
            player2.ResetMoves();
            SelectFirstMoveChar();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}