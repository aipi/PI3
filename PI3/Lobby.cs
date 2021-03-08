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
    public partial class LobbyForm : Form
    {
        public LobbyForm()
        {
            InitializeComponent();
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            filterMatches.Visible = true;
            filterMatches.SelectedItem = "Todos";
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

        private void btnStartMatch_Click(object sender, EventArgs e)
        {
            int selectedGame = Convert.ToInt32(dgvListMatches.CurrentRow.Cells["id"].Value);
            string partida = Jogo.IniciarPartida(selectedGame, "1234");
            lblGamersList.Text = partida;
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            string partida = Jogo.CriarPartida("Partida 2", "12345");
            Console.WriteLine(partida);
        }

        private void filterMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listMatches = Jogo.ListarPartidas(filterMatches.SelectedItem.ToString().Substring(0, 1));
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
    }
}
