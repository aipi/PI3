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
        private PictureBox[,] pBDices;

        public Game(int id, string password, string color)
        {
            this.ID = id;
            this.Password = password;
            this.Color = color;
            InitializeComponent();
            string iniciarPartida = Jogo.IniciarPartida(this.ID, this.Password);
            this.Dices = new int[4, 2];
            this.pBDices = new PictureBox[4, 2];
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            string rollDice = Jogo.RolarDados(this.ID, this.Password);
            string[] lines = rollDice.Replace("\r", "").Split('\n');
            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    string value = lines[i];
                    char[] values = value.ToCharArray();
                    for (int j = 0; j < values.Length; j++)
                    {
                        this.Dices[i, j] = (int)Char.GetNumericValue(values[j]);
                        this.showDices(i, j);
                    }
                }
            }
        }

        private void showDices(int i, int j)
        {
            PictureBox pbDice;
            switch (this.Dices[i, j])
            {
                case 1:
                    pbDice = pB1;
                    break;
                case 2:
                    pbDice = pB2;
                    break;
                case 3:
                    pbDice = pB3;
                    break;
                case 4:
                    pbDice = pB4;
                    break;
                case 5:
                    pbDice = pB5;
                    break;
                case 6:
                    pbDice = pB6;
                    break;
                default:
                    pbDice = pB1;
                    break;
            }
            this.pBDices[i, j] = new PictureBox();
            this.pBDices[i, j].Image = pbDice.Image;
            this.pBDices[i, j].Width = pbDice.Width;
            this.pBDices[i, j].Height = pbDice.Height;
            this.pBDices[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
            this.pBDices[i, j].Location = new Point((j + 1) * 40, (i + 1) * 40);
            this.Controls.Add(this.pBDices[i, j]);
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pB2_Click(object sender, EventArgs e)
        {

        }

        private void Tabuleiro_Click(object sender, EventArgs e)
        {

        }
    }
}
