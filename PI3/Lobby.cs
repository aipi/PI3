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
        private int selectedMatchID;
        private int ID;
        private string Password;
        private string Color;

        public LobbyForm()
        {
            InitializeComponent();
            lblVersion.Text = "Versão: " + Jogo.Versao;
        }

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            this.Size = new Size(670, 350);
            this.visible(new List<Control> {
                lblMatchesList, filterMatches, dgvListMatches, btnListGamers
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
                lblGamersList, dgvListGamers, btnStartMatch, btnCreateGamer
            });
            this.unvisible(new List<Control>{
                lblMatchesList, filterMatches, dgvListMatches
            });
            this.selectedMatchID = Convert.ToInt32(dgvListMatches.CurrentRow.Cells["id"].Value);
            string listGamers = Jogo.ListarJogadores(this.selectedMatchID);
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
            Game startGame = new Game(this.ID, this.Password, this.Color);
            startGame.Show();
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            this.visible(new List<Control> {
                lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirmCreateMatch
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

        private void btnConfirmCreateMatch_Click(object sender, EventArgs e)
        {
            string partida = Jogo.CriarPartida(txtboxName.Text, txtboxPassword.Text);
            if (txtboxPassword.Text == "" || txtboxName.Text == ""){
                MessageBox.Show(
                    partida,
                    partida,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if (txtboxPassword.Text.Length > 10) {
                MessageBox.Show(
                    partida,
                    partida,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if (txtboxName.Text.Length > 50) {
                MessageBox.Show(
                    partida,
                    partida,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else {
                filterMatches.SelectedItem = "Abertas";
                this.btnListMatches_Click(sender, e);
                this.unvisible(new List<Control> {
                    lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirmCreateMatch
                });

                this.visible(new List<Control> {
                    btnCreateMatch, btnListGamers, btnListMatches
                });
            }
            txtboxName.Text = "";
            txtboxPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.unvisible(new List<Control> {
                lblName, txtboxName, lblPassword, txtboxPassword, btnConfirmCreateMatch, btnCancel
            });
            this.visible(new List<Control> {
                btnCreateMatch, btnStartMatch, btnListMatches, btnListGamers
            });
            if (pbBackground.Visible) {
                btnStartMatch.Visible = false;
            }
        }

        private void btnConfirmCreateGamer_Click(object sender, EventArgs e)
        {
            string matchData= Jogo.EntrarPartida(this.selectedMatchID, txtboxName.Text, txtboxPassword.Text);

            if (txtboxPassword.Text == "" || txtboxName.Text == "") {
                MessageBox.Show(
                    matchData,
                    matchData,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if (txtboxPassword.Text.Length > 10) {
                MessageBox.Show(
                    matchData,
                    matchData,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if (txtboxName.Text.Length > 50) {
                MessageBox.Show(
                    matchData,
                    matchData,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } else if (matchData.Contains("ERRO:Senha Incorreta!")) {
                MessageBox.Show(
                    matchData,
                    matchData,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            } else {
                this.btnListGamers_Click(sender, e);
                this.unvisible(new List<Control> {
                    lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirmCreateMatch, btnConfirmCreateGamer
                });

                    this.visible(new List<Control> {
                    btnCreateMatch, btnListGamers, btnListMatches
                });
                matchData = matchData.Replace("\r", "").Replace("\n", "");
                string[] data = matchData.Split(',');
                this.ID = Convert.ToInt32(data[0]);
                this.Password = data[1];
                this.Color = data[2];
            }
            txtboxName.Text = "";
            txtboxPassword.Text = "";
        }

        private void btnCreateGamer_Click(object sender, EventArgs e)
        {
            this.visible(new List<Control> {
                lblName, lblPassword, txtboxName, txtboxPassword, btnCancel, btnConfirmCreateGamer, btnConfirmCreateGamer
            });
            this.unvisible(new List<Control> {
                btnCreateMatch, btnListGamers, btnListMatches, btnCreateGamer, btnConfirmCreateMatch
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

        private void pbBackground_Click(object sender, EventArgs e)
        {

        }

        private void LobbyForm_Load(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
