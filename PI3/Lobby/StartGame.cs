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
        private string MatchID;
        public StartGame(int GamerID, string Password, string Color, string matchID)
        {
            InitializeComponent();
            this.GamerID = GamerID;
            this.Password = Password;
            this.Color = Color;
            this.MatchID = matchID;
            btnStartGame.MouseEnter += OnMouseEnterBtnStartGame;
            lblVersion.Text = lblVersion.Text + Jogo.Versao;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play.CantStop playGame = new Play.CantStop(this.GamerID, this.MatchID, this.Color, this.Password);
            Jogo.IniciarPartida(this.GamerID, this.Password);
            playGame.Show();
        }

        private void OnMouseEnterBtnStartGame(object sender, EventArgs e)
        {
            btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
