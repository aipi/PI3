using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace PI3.Lobby
{
    public partial class StartGame : Form
    {
        private int GamerID;
        private string Password;
        private string Color;
        private string matchID;
        public StartGame(int GamerID, string Password, string Color)
        {
            InitializeComponent();
            this.GamerID = GamerID;
            this.Password = Password;
            this.Color = Color;
            this.matchID = Jogo.IniciarPartida(this.GamerID, this.Password);
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play.CantStop playGame = new Play.CantStop(this.GamerID, this.matchID, this.Color, this.Password);
            playGame.Show();
        }
    }
}
