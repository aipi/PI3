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
        private int[,] Dices;
        private PictureBox pictureBox;

        public Game(int id, string password, string color)
        {
            this.ID = id;
            this.Password = password;
            this.Color = color;
            InitializeComponent();
            string iniciarPartida = Jogo.IniciarPartida(this.ID, this.Password);
            this.Dices = new int[4, 2];
            this.pictureBox = new PictureBox();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            string rollDice = Jogo.RolarDados(this.ID, this.Password);
            string[] lines = rollDice.Replace("\r", "").Split('\n');
            for (int i = 0; i < lines.Length - 2; i++) 
            {
                if (lines[i] != "")
                {
                    string value = lines[i];
                    char[] values = value.ToCharArray();
                    Console.WriteLine(lines[i]);
                    for (int j = 0; j < values.Length; j++)
                    {
                        this.Dices[i, j] = (int)Char.GetNumericValue(values[j]);
                        var x = (int)Char.GetNumericValue(values[j]);
                    }
                }
            }

            this.pictureBox.Image = pB001.Image;
            this.pictureBox.Width = pB001.Width;
            this.pictureBox.Height = pB001.Height;
            this.pictureBox.Top = pB001.Top;
            this.pictureBox.Left = pB001.Left;
            this.pictureBox.Show();
            this.Controls.Add(this.pictureBox);
            Console.WriteLine(this.pictureBox);
        }
    }
}
