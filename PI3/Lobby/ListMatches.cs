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
    public partial class ListMatches : Form
    {
        public ListMatches()
        {
            InitializeComponent();
            filterMatches.SelectedItem = "Todos";
            btnBack.MouseEnter += OnMouseEnterBtnBack;
            btnListMatches.MouseEnter += OnMouseEnterBtnListMatches;
        }

        private void OnMouseEnterBtnListMatches(object sender, EventArgs e)
        {
            btnListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnBack(object sender, EventArgs e)
        {
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameLobby start = new GameLobby();
            start.Show();
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

        private void btnListMatches_Click(object sender, EventArgs e)
        {
            int matchID = Convert.ToInt32(dgvListMatches.CurrentRow.Cells["id"].Value);
            this.Hide();
            ListGamers gamers = new ListGamers(matchID);
            gamers.Show();
        }
    }
}
