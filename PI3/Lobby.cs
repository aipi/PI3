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

namespace PI3
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            Jogo.CriarPartida("Partida 2", "1234");
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            string listMatches = Jogo.ListarPartidas("T");
            listMatches = listMatches.Replace("\r", "");
            string[] lines = listMatches.Split('\n');
            List<Match> matches = new List<Match>();

            for (int i = 0; i < lines.Length - 1; i++)
            {

                if (lines[i] != "")
                {
                    Match match = new Match();
                    match.setter(lines[i]);
                    matches.Add(match);
                }
            }
            dgvListMatches.DataSource = matches;
        }

        private void btnListGamers_Click(object sender, EventArgs e)
        {
            int selectedMatch = Convert.ToInt32(dgvListMatches.CurrentRow.Cells["id"].Value);
            string listGamers = Jogo.ListarJogadores(selectedMatch);
            listGamers = listGamers.Replace("\r", "");
            string[] lines = listGamers.Split('\n');
            List<Gamer> gamers = new List<Gamer>();

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    Gamer gamer = new Gamer();
                    gamer.setter(lines[i]);
                    gamers.Add(gamer);
                }
            }
            dgvListGamers.DataSource = gamers;

        }
    }
}
