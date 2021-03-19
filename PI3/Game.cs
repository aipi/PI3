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
    public partial class Game : Form
    {
        private int ID;
        private string Password;
        private string Color;

        public Game(int id, string password, string color)
        {
            this.ID = id;
            this.Password = password;
            this.Color = color;
            InitializeComponent();
            string iniciarPartida = Jogo.IniciarPartida(this.ID, this.Password);
            label1.Text = iniciarPartida + " " + this.Password + " " + this.Color + " ";
        }
    }
}
