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
        private readonly int GamerID;
        private readonly string MatchID;
        private readonly string Password;
        private readonly string GamerColor;
        private List<Gamer> gamers;
        private int[,] Dices;
        private string[,] Gamers;
        private PictureBox[,] pBDices;

        public CantStop(int GamerID, string MatchID, string GamerColor, string Password)
        {
            this.GamerID = GamerID;
            this.MatchID = MatchID;
            this.Password = Password;
            this.GamerColor = GamerColor;
            this.Dices = new int[4, 2];
            this.Gamers = new string[4, 3];
            this.pBDices = new PictureBox[4, 2];
            InitializeComponent();
            btnRollDice.MouseEnter += OnMouseEnterBtnRollDice;
            btnPause.MouseEnter += OnMouseEnterBtnPause;
            btnMoviment.MouseEnter += OnMouseEnterBtnMoviment;
            this.setGamers();
            this.setBoardData();
        }

        private void setGamers()
        {
            string listGamers = Jogo.ListarJogadores(Convert.ToInt32(this.MatchID));
            listGamers = listGamers.Replace("\r", "");
            string[] lines = listGamers.Split('\n');
            this.gamers = new List<Gamer>();

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    Gamer gamer = new Gamer();
                    gamer.setter(lines[i]);
                    gamers.Add(gamer);
                }
            }
        }

        private void setBoardData()
        {
            string boardData = Jogo.ExibirTabuleiro(1);
            string[] lines = boardData.Replace("\r", "").Split('\n');
            string[,] board = new string[lines.Length, 4];
            
            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    Play.Board gameBoard = new Play.Board();
                    gameBoard.setter(lines[i]);
                    showBoard(gameBoard);
                }
            }
            Console.WriteLine(lines);
        }

        private Gamer getGamer(string gamerID)
        {
            for (int i = 0; i < this.gamers.Count ; i++)
            {
                if (this.gamers[i].id == gamerID)
                {
                    return this.gamers[i];
                }
            }
            return this.gamers[0];
        }

        private void showBoard(Play.Board gameBoard)
        {
            Gamer gamer = this.getGamer(gameBoard.gamerID);
            pb1 = new PictureBox();
            switch (gamer.color)
            {
                case "Vermelho":
                    pb1.Image = pbRed.Image;
                    pb1.Width = pbRed.Width;
                    pb1.Height = pbRed.Height;
                    pb1.Location = new Point(46 + (gameBoard.trilha * 23), 292 - (gameBoard.position * 14));
                    break;
                case "Azul":
                    pb1.Image = pbBlue.Image;
                    pb1.Width = pbBlue.Width;
                    pb1.Height = pbBlue.Height;
                    pb1.Location = new Point(54 + (gameBoard.trilha * 23), 292 - (gameBoard.position * 14));
                    break;
                case "Verde":
                    pb1.Image = pbGreen.Image;
                    pb1.Width = pbGreen.Width;
                    pb1.Height = pbGreen.Height;
                    pb1.Location = new Point(46 + (gameBoard.trilha * 23), 299 - (gameBoard.position * 14));
                    break;
                case "Amarelo":
                    pb1.Image = pbYellow.Image;
                    pb1.Width = pbYellow.Width;
                    pb1.Height = pbYellow.Height;
                    pb1.Location = new Point(54 + (gameBoard.trilha * 23), 299 - (gameBoard.position * 14));
                    break;
                default:
                    break;
            }
                    
            pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb1.BackColor = Color.Transparent;
            pbBackground.Controls.Add(pb1);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            string rollDice = Jogo.RolarDados(this.GamerID, this.Password);
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
