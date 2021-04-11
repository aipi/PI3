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

namespace PI3.Play
{

    public partial class CantStop : Form
    {
        private int GamerID;
        private string MatchID;
        private string Password;
        private string Color;
        private int[,] Dices;
        private PictureBox[,] pBDices;

        public CantStop(int GamerID, string MatchID, string Color, string Password)
        {
            this.GamerID = GamerID;
            this.MatchID = MatchID;
            this.Password = Password;
            this.Color = Color;
            this.Dices = new int[4, 2];
            this.pBDices = new PictureBox[4, 2];
            InitializeComponent();
            btnRollDice.MouseEnter += OnMouseEnterBtnRollDice;
            btnPause.MouseEnter += OnMouseEnterBtnPause;
            btnMoviment.MouseEnter += OnMouseEnterBtnMoviment;
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            string rollDice = "11\r\n23\r\n35\r\n41\r\n";
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
                        if (j == 1)
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
                    pbDice = pb1;
                    break;
                case 2:
                    pbDice = pb2;
                    break;
                case 3:
                    pbDice = pb3;
                    break;
                case 4:
                    pbDice = pb4;
                    break;
                case 5:
                    pbDice = pb5;
                    break;
                case 6:
                    pbDice = pb6;
                    break;
                default:
                    pbDice = pb1;
                    break;
            }
            this.pBDices[i, j] = new PictureBox();
            this.pBDices[i, j].Image = pbDice.Image;
            this.pBDices[i, j].Width = pbDice.Width;
            this.pBDices[i, j].Height = pbDice.Height;
            this.pBDices[i, j].Visible = true;
            this.pBDices[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
            switch (i)
            {
                case 0:
                    this.pBDices[i, j].Location = pb1.Location;
                    break;
                case 1:
                    this.pBDices[i, j].Location = pb6.Location;
                    break;
                case 2:
                    this.pBDices[i, j].Location = pb5.Location;
                    break;
                case 3:
                    this.pBDices[i, j].Location = pb4.Location;
                    break;
                default:
                    this.pBDices[i, j].Location = pb1.Location;
                    break;
            }
            this.Controls.Add(this.pBDices[i, j]);
        }

        private void OnMouseEnterBtnCreateMatch(object sender, EventArgs e)
        {
            btnRollDice.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnRollDice(object sender, EventArgs e)
        {
            btnRollDice.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnPause(object sender, EventArgs e)
        {
            btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnMoviment(object sender, EventArgs e)
        {
            btnMoviment.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
