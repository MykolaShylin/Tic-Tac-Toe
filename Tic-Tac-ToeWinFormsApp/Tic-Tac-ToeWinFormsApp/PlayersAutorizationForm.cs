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
        public PlayersAutorizationForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Hide();
            if(player1TextBox.Text != string.Empty && player2TextBox.Text != string.Empty && player1CharTextBox.Text != string.Empty && player2CharTextBox.Text != string.Empty)
            {
                player1 = new Player(player1TextBox.Text, player1CharTextBox.Text.ToUpper());
                player2 = new Player(player2TextBox.Text, player2CharTextBox.Text.ToUpper());
                var newGame = new GameForm(player1, player2);
                newGame.Show();
                
            }
            else
            {
                MessageBox.Show("Не все строки авториизации заполнены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void player1CharTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(player1CharTextBox.Text.ToUpper() == "Х")
            {
                player2CharTextBox.Text = "О";
            }
            else if (player1CharTextBox.Text.ToUpper() == "О")
            {
                player2CharTextBox.Text = "Х";
            }
            else
            {
                MessageBox.Show("Недопустимый символ, выбирете Х либо О!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                player1CharTextBox.Clear();
            }
        }

        private void player2CharTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (player2CharTextBox.Text.ToUpper() == "Х")
            {
                player1CharTextBox.Text = "О";
            }
            else if (player2CharTextBox.Text.ToUpper() == "О")
            {
                player1CharTextBox.Text = "Х";
            }
            else
            {
                MessageBox.Show("Недопустимый символ, выбирете Х либо О!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                player2CharTextBox.Clear();
            }
        }
    }
}
