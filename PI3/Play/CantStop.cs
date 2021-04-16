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
        private PictureBox[] pBDices;
        private PictureBox[] pbGamersPositions;
        System.Windows.Forms.Timer t = null;

        public CantStop(int GamerID, string MatchID, string GamerColor, string Password)
        {
            this.GamerID = GamerID;
            this.MatchID = MatchID;
            this.Password = Password;
            this.GamerColor = GamerColor;
            this.Gamers = new string[4, 3];
            this.pBDices = new PictureBox[4];
            this.Dices = new int[4, 2];
            InitializeComponent();
            StartTimer();
            lblVersion.Text = lblVersion.Text + Jogo.Versao;
            btnRollDice.MouseEnter += OnMouseEnterBtnRollDice;
            btnPause.MouseEnter += OnMouseEnterBtnPause;
            btnMoviment.MouseEnter += OnMouseEnterBtnMoviment;
            btnExit.MouseEnter += OnMouseEnterBtnExit;
            this.setGamers();
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 10;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;

        }

        void t_Tick(object sender, EventArgs e)
        {
            string checkTurn = Jogo.VerificarVez(Convert.ToInt32(this.MatchID));

            if (checkTurn.Contains("J") && checkTurn.Contains(this.GamerID.ToString()))
            {
                btnRollDiceDeactivated.Visible = false;
                btnMovimentDeactivate.Visible = false;
                btnPauseDeactivate.Visible = false;

            }
            else
            {
                btnRollDiceDeactivated.Visible = true;
                btnMovimentDeactivate.Visible = true;
                btnPauseDeactivate.Visible = true;
            }
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
            string boardData = Jogo.ExibirTabuleiro(Convert.ToInt32(MatchID));
            string[] lines = boardData.Replace("\r", "").Split('\n');
            string[,] board = new string[lines.Length, 4];
            this.pbGamersPositions = new PictureBox[lines.Length];

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    Play.Board gameBoard = new Play.Board();
                    gameBoard.setter(lines[i]);
                    showBoard(gameBoard, i);
                }
            }
        }

        private void showBoard(Play.Board gameBoard, int i)
        {
            Gamer gamer = this.getGamer(gameBoard.gamerID);
            this.pbGamersPositions[i] = new PictureBox();
            switch (gamer.color)
            {
                case "Vermelho":
                    
                    if (gameBoard.type == "A")
                    {
                        this.pbGamersPositions[i].Image = pbRedWhite.Image;
                    }
                    else
                    {
                        this.pbGamersPositions[i].Image = pbRed.Image;
                    }
                    
                    this.pbGamersPositions[i].Width = pbRed.Width;
                    this.pbGamersPositions[i].Height = pbRed.Height;
                    this.pbGamersPositions[i].Location = new Point(46 + (gameBoard.trilha * 23), 292 - (gameBoard.position * 14));
                    break;
                case "Azul":
                    if (gameBoard.type == "A")
                    {
                        this.pbGamersPositions[i].Image = pbBlueWhite.Image;
                    }
                    else
                    {
                        this.pbGamersPositions[i].Image = pbBlue.Image;
                    }
                    this.pbGamersPositions[i].Width = pbBlue.Width;
                    this.pbGamersPositions[i].Height = pbBlue.Height;
                    this.pbGamersPositions[i].Location = new Point(54 + (gameBoard.trilha * 23), 292 - (gameBoard.position * 14));
                    break;
                case "Verde":
                    if (gameBoard.type == "A")
                    {
                        this.pbGamersPositions[i].Image = pbGreenWhite.Image;
                    }
                    else
                    {
                        this.pbGamersPositions[i].Image = pbGreen.Image;
                    }
                    this.pbGamersPositions[i].Width = pbGreen.Width;
                    this.pbGamersPositions[i].Height = pbGreen.Height;
                    this.pbGamersPositions[i].Location = new Point(46 + (gameBoard.trilha * 23), 299 - (gameBoard.position * 14));
                    break;
                case "Amarelo":
                    if (gameBoard.type == "A")
                    {
                        this.pbGamersPositions[i].Image = pbYellowWhite.Image;
                    }
                    else
                    {
                        this.pbGamersPositions[i].Image = pbYellow.Image;
                    }                    
                    this.pbGamersPositions[i].Width = pbYellow.Width;
                    this.pbGamersPositions[i].Height = pbYellow.Height;
                    this.pbGamersPositions[i].Location = new Point(54 + (gameBoard.trilha * 23), 299 - (gameBoard.position * 14));
                    break;
                default:
                    break;
            }
            this.pbGamersPositions[i].Visible = true;
            this.pbGamersPositions[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGamersPositions[i].BackColor = Color.Transparent;
            pbBackground.Controls.Add(this.pbGamersPositions[i]);
            this.pbGamersPositions[i].BringToFront();
        }

        private Gamer getGamer(string gamerID)
        {
            for (int i = 0; i < this.gamers.Count; i++)
            {
                if (this.gamers[i].id == gamerID)
                {
                    return this.gamers[i];
                }
            }
            return this.gamers[0];
        }

        private void resetDices()
        {
            PictureBox[] dices = { pb1, pb2, pb3, pb4, pb5, pb6};
            foreach (PictureBox dice in dices)
            {
                dice.Visible = false;
            }
            foreach (PictureBox dice in this.pBDices)
            {
                this.Controls.Remove(dice);
            }
            Array.Clear(this.Dices, 0, this.Dices.Length);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            //string rollDice = "11\r\n24\r\n32\r\n46\r\n";
            string rollDice = Jogo.RolarDados(this.GamerID, this.Password);
            if (rollDice.Contains("ERRO"))
            {
                lblError.Text = rollDice;
            }
            else
            {
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
            this.pBDices[i] = new PictureBox();
            this.pBDices[i].Image = pbDice.Image;
            this.pBDices[i].Width = pbDice.Width;
            this.pBDices[i].Height = pbDice.Height;
            this.pBDices[i].Visible = true;
            this.pBDices[i].SizeMode = PictureBoxSizeMode.StretchImage;
            switch (i)
            {
                case 0:
                    this.pBDices[i].Location = pb1.Location;
                    break;
                case 1:
                    this.pBDices[i].Location = pb6.Location;
                    break;
                case 2:
                    this.pBDices[i].Location = pb5.Location;
                    break;
                case 3:
                    this.pBDices[i].Location = pb4.Location;
                    break;
                default:
                    break;
            }
            this.Controls.Add(this.pBDices[i]);
        }

        private void resetGamersPosition()
        {
            foreach (PictureBox gamerPosition in this.pbGamersPositions)
            {
                pbBackground.Controls.Remove(gamerPosition);
            }
            Array.Clear(this.pbGamersPositions, 0, this.pbGamersPositions.Length);
        }

        private void btnMoviment_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string moviment = tbMove.Text;
            string movimentReturn = Jogo.Mover(this.GamerID, this.Password, "1234", moviment);

            if (movimentReturn.Contains("ERRO"))
            {
                lblError.Text = movimentReturn;
                lblError.Visible = true;
            } else
            {
                resetGamersPosition();
                string result = Jogo.ExibirTabuleiro(Convert.ToInt32(this.MatchID));
                this.resetDices();
                setBoardData();
            }
            tbMove.Text = "";

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            string pause = Jogo.Parar(this.GamerID, this.Password);
            if (pause.Contains("ERRO"))
            {
                lblError.Text = pause;
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBox.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lobby.GameLobby gameLobby = new Lobby.GameLobby();
            gameLobby.Show();
        }

        private void OnMouseEnterBtnExit(object sender, EventArgs e)
        {
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
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
