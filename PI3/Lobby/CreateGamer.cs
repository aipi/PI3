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
    public partial class CreateGamer : Form
    {
        private int matchID;
        public CreateGamer(int matchID)
        {
            InitializeComponent();
            btnCancel.MouseEnter += this.OnMouseEnterBtnCancel;
            btnCreate.MouseEnter += this.OnMouseEnterBtnCreate;
            this.matchID = matchID;
        }

        private void OnMouseEnterBtnCreate(object sender, EventArgs e)
        {
            btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void OnMouseEnterBtnCancel(object sender, EventArgs e)
        {
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListGamers gamersList = new ListGamers(this.matchID);
            gamersList.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string match = Jogo.EntrarPartida(this.matchID, tbName.Text, tbPassword.Text);
            if (match.Contains("ERRO"))
            {
                lblError.Text = match;
                lblError.Visible = true;
            }
            else
            {
                match = match.Replace("\r", "").Replace("\n", "");
                string[] data = match.Split(',');
                int ID = Convert.ToInt32(data[0]);
                string Password = data[1];
                string Color = data[2];
                this.Hide();
                StartGame gamerList = new StartGame(ID, Password, Color, this.matchID.ToString());
                gamerList.Show();
            }
        }
    }
}
