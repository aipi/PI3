using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Iniciar_Jogo_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = new PictureBox();
            p.Left = 100;
            p.Top = 100;
            p.Width = 100;
            p.Height = 100;
            p.BackColor = Color.Black;
            this.Controls.Add(p);
        }
    }
}
