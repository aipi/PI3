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
        public ListGamers(int matchID)
        {
            InitializeComponent();
            this.matchID = matchID;
            this.listGamers();
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

        private void btnCreateGamer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGamer createGamer = new CreateGamer(this.matchID);
            createGamer.Show();
        }

        private void btnStartMatch_Click(object sender, EventArgs e)
        {

        }
    }
}
