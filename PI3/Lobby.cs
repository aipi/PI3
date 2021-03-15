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
    public partial class LobbyForm : Form{
        public LobbyForm()
        {
            InitializeComponent();
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            this.Size = new Size(670, 350);
            this.visible(new List<Control> {
                lblMatchesList, filterMatches, dgvListMatches, btnStartMatch, btnListGamers
            });
            List<Control> unvisibleControls = new List<Control> {
                pbBackground
            };
            if (dgvListMatches.Visible)
            {
                unvisibleControls.Add(lblGamersList);
                unvisibleControls.Add(dgvListGamers);
            }
            this.unvisible(unvisibleControls);
            filterMatches.SelectedItem = "Todos";
        }

        private void btnListGamers_Click(object sender, EventArgs e)
        {
            this.visible(new List<Control>{
                lblGamersList, dgvListGamers
            });
            this.unvisible(new List<Control>{
                lblMatchesList, filterMatches, dgvListMatches
            });
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
            this.Hide();
            Game startGame = new Game();
            startGame.Show();
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            this.visible(new List<Control> {
                lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirm
            });
            this.unvisible(new List<Control> {
                btnCreateMatch, btnStartMatch, btnListGamers, btnListMatches
            });
        }

        private void filterMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listMatches = Jogo.ListarPartidas(
                filterMatches.SelectedItem.ToString().Substring(0, 1)
            );
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.unvisible(new List<Control> {
                lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirm
            });

            this.visible(new List<Control> {
                btnCreateMatch, btnStartMatch, btnListGamers, btnListMatches
            });

            Game p1 = new Game();
            Convert.ToInt32(Jogo.CriarPartida(txtboxName.Text, txtboxPassword.Text));
            txtboxName.Text = "";
            txtboxPassword.Text = "";

            string partida = Jogo.CriarPartida("Partida 2", "12345");
            Console.WriteLine(partida);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.unvisible(new List<Control> {
                lblName, txtboxName, lblPassword, txtboxPassword, btnConfirm, btnCancel
            });
            this.visible(new List<Control> {
                btnCreateMatch, btnStartMatch, btnListMatches, btnListGamers
            });
        }

        private void unvisible(List<Control> unvisibleControls)
        {
            for (int i = 0; i < unvisibleControls.Count; i++)
            {
                unvisibleControls[i].Visible = false;
            }

        }

        private void visible(List<Control> visibleControls)
        {
            for (int i = 0; i < visibleControls.Count; i++)
            {
                visibleControls[i].Visible = true;
            }

        }
    }
}
