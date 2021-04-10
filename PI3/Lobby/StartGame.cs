using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.Lobby
{
    public partial class StartGame : Form
    {
        private int ID;
        private string Password;
        private string Color;
        public StartGame(int ID, string Password, string Color)
        {
            InitializeComponent();
            this.ID = ID;
            this.Password = Password;
            this.Color = Color;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play.CantStop playGame = new Play.CantStop();
            playGame.Show();
        }
    }
}
