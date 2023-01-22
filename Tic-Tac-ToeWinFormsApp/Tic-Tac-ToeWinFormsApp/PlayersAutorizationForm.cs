using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_ToeWinFormsApp
{
    public partial class PlayersAutorizationForm : Form
    {
        private Player player1;
        private Player player2;
        private bool _player1Ready = false;
        private bool _player2Ready = false;
        private string player1Char;
        private string player2Char;
        public PlayersAutorizationForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            if(player1TextBox.Text != string.Empty && player2TextBox.Text != string.Empty && _player1Ready && _player2Ready)
            {
                player1 = new Player(player1TextBox.Text, player1Char);
                player2 = new Player(player2TextBox.Text, player2Char);
                var newGame = new GameForm(player1, player2);
                newGame.Show();
                
            }
            else
            {
                MessageBox.Show("Не все строки авториизации заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void player1CharButtonX_Click(object sender, EventArgs e)
        {
            player1CharButtonO.BackColor = Color.Transparent;
            player2CharButtonX.BackColor = Color.Transparent;
            player1CharButtonX.BackColor = Color.PaleGreen;
            player2CharButtonO.BackColor = Color.PaleGreen;
            _player1Ready = true;
            _player2Ready = true;
            player1Char = player1CharButtonX.Text;
            player2Char = player2CharButtonO.Text;
        }

        private void player1CharButtonO_Click(object sender, EventArgs e)
        {
            player1CharButtonO.BackColor = Color.PaleGreen;
            player2CharButtonX.BackColor = Color.PaleGreen;
            player1CharButtonX.BackColor = Color.Transparent;
            player2CharButtonO.BackColor = Color.Transparent;
            _player1Ready = true;
            _player2Ready = true;
            player1Char = player1CharButtonO.Text;
            player2Char = player2CharButtonX.Text;
        }

        private void player2CharButtonX_Click(object sender, EventArgs e)
        {
            player1CharButtonO.BackColor = Color.PaleGreen;
            player2CharButtonX.BackColor = Color.PaleGreen;
            player1CharButtonX.BackColor = Color.Transparent;
            player2CharButtonO.BackColor = Color.Transparent;
            _player1Ready = true;
            _player2Ready = true;
            player1Char = player1CharButtonO.Text;
            player2Char = player2CharButtonX.Text;
        }

        private void player2CharButtonO_Click(object sender, EventArgs e)
        {
            player1CharButtonO.BackColor = Color.Transparent;
            player2CharButtonX.BackColor = Color.Transparent;
            player1CharButtonX.BackColor = Color.PaleGreen;
            player2CharButtonO.BackColor = Color.PaleGreen;
            _player1Ready = true;
            _player2Ready = true;
            player1Char = player1CharButtonX.Text;
            player2Char = player2CharButtonO.Text;
        }
    }
}
