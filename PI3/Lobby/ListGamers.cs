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
    public partial class ListGamers : Form
    {
        private int matchID;
        private string status;
        public ListGamers(int matchID, string status)
        {
            InitializeComponent();
            this.matchID = matchID;
            this.status = status;
            lblVersion.Text = lblVersion.Text + Jogo.Versao;

            btnBack.MouseEnter += OnMouseEnterBtnBack;
            btnCreateGamer.MouseEnter += OnMouseEnterBtnCreateGamer;
            btnShowMatch.MouseEnter += OnMouseEnterBtnShowMatch;
        }

        private void setGameStatus()
        {
            if (status == "J")
            {
                lblStatus.Text = "Status: Jogando";
                btnShowMatch.Visible = true;
            }
            else if (status == "A")
            {
                lblStatus.Text = "Status: Aberta";
                btnCreateGamer.Visible = true;
            }
            else
            {
                lblStatus.Text = "Status: Excluída";
            }
        }

        private void OnMouseEnterBtnCreateGamer(object sender, EventArgs e)
        {
            btnCreateGamer.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnShowMatch(object sender, EventArgs e)
        {
            btnShowMatch.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnBack(object sender, EventArgs e)
        {
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListMatches matchesList = new ListMatches();
            matchesList.Show();
        }

        private void listGamers() {
            string listGamers = Jogo.ListarJogadores(this.matchID);
            listGamers = listGamers.Replace("\r", "");
            string[] lines = listGamers.Split('\n');
            List<Gamer> gamers = new List<Gamer>();
            // TODO: Partida J Exibir partida
            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    Gamer gamer = new Gamer();
                    gamer.setter(lines[i]);
                    gamers.Add(gamer);
                    switch (gamer.color)
                    {
                        case "Vermelho":
                            lblActiveRed.Visible = true;
                            lblInactivateRed.Visible = false;
                            break;
                        case "Amarelo":
                            lblActiveYellow.Visible = true;
                            lblInactivateYellow.Visible = false;
                            break;
                        case "Verde":
                            lblActiveGreen.Visible = true;
                            lblInactivateGreen.Visible = false;
                            break;
                        case "Azul":
                            lblActiveBlue.Visible = true;
                            lblInactivateBlue.Visible = false;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void btnCreateGamer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGamer createGamer = new CreateGamer(this.matchID);
            createGamer.Show();
        }

        private void ListGamers_Load(object sender, EventArgs e)
        {
            this.setGameStatus();
            this.listGamers();
        }

        private void btnShowMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play.CantStop showMatch = new Play.CantStop(0, this.matchID.ToString(), "", "");
            showMatch.Show();
        }
    }
}
