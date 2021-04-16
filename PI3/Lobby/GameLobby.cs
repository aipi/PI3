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
    public partial class GameLobby : Form
    {
        public GameLobby()
        {
            InitializeComponent();
            btnCreateMatch.MouseEnter += OnMouseEnterBtnCreateMatch;
            btnListMatches.MouseEnter += OnMouseEnterBtnListMatches;
            lblVersion.Text = lblVersion.Text + Jogo.Versao;
        }

        private void OnMouseEnterBtnCreateMatch(object sender, EventArgs e)
        {
            btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnListMatches(object sender, EventArgs e)
        {
            btnListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateMatch match = new CreateMatch();
            match.Show();
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListMatches listaPartidas = new ListMatches();
            listaPartidas.Show();
        }
    }
}
