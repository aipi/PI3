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
        private int idPartida;
        public CreateGamer(int idPartida)
        {
            InitializeComponent();
            btnCancel.MouseEnter += this.OnMouseEnterBtnCancel;
            btnCreate.MouseEnter += this.OnMouseEnterBtnCreate;
            this.idPartida = idPartida;
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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string partida = Jogo.EntrarPartida(this.idPartida, tbName.Text, tbPassword.Text);
            if (partida.Contains("ERRO"))
            {
                lblError.Text = partida;
                lblError.Visible = true;
            }
            else
            {
                // this.Hide();
                // ListMatches matchList = new ListMatches();
                // matchList.Show();
            }
        }
    }
}
