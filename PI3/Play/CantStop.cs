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
        List<Permutation> Permutations;
        List<Options> Options;
        System.Windows.Forms.Timer t = null;

        public CantStop(int GamerID, string MatchID, string GamerColor, string Password)
        {
            this.Permutations = new List<Permutation>();
            this.Options = new List<Options>();
            this.GamerID = GamerID;
            this.MatchID = MatchID;
            this.Password = Password;
            this.GamerColor = GamerColor;
            this.Gamers = new string[4, 3];
            this.pBDices = new PictureBox[4];
            this.Dices = new int[4, 2];
            InitializeComponent();
            this.Size = new System.Drawing.Size(this.Width + 15, this.Height + 15);
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
            t.Interval = 5000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;

        }
        void checkTurn(string turn)
        {
            string gamers = Jogo.ListarJogadores(Convert.ToInt32(MatchID));
            string[] listGamers = gamers.Replace("\r", "").Split('\n');
            pbYellowO.Visible = true;
            pbRedO.Visible = true;
            pbBlueO.Visible = true;
            pbGreenO.Visible = true;
            foreach (string gamer in listGamers)
            {
                var x = turn.Replace("\r\n", "").Split(',')[1];
                if (gamer.Contains(x))
                {
                    if (gamer.Contains("Vermelho"))
                    {
                        lblRed.Visible = true;
                        pbRedO.Visible = false;
                        lblGreen.Visible = false;
                        lblYellow.Visible = false;
                        lblBlue.Visible = false;
                    }
                    else if (gamer.Contains("Azul"))
                    {
                        lblBlue.Visible = true;
                        pbBlueO.Visible = false;
                        lblRed.Visible = false;
                        lblGreen.Visible = false;
                        lblYellow.Visible = false;
                    }
                    else if (gamer.Contains("Amarelo"))
                    {
                        lblYellow.Visible = true;
                        pbYellowO.Visible = false;
                        lblRed.Visible = false;
                        lblGreen.Visible = false;
                        lblBlue.Visible = false;
                    }
                    else if (gamer.Contains("Verde"))
                    {
                        lblGreen.Visible = true;
                        pbGreenO.Visible = false;
                        lblRed.Visible = false;
                        lblYellow.Visible = false;
                        lblBlue.Visible = false;
                    }
                }
            }
        }

        async void t_Tick(object sender, EventArgs e)
        {
            string turn = Jogo.VerificarVez(Convert.ToInt32(this.MatchID));
            this.checkTurn(turn);
            string history = Jogo.ExibirHistorico(Convert.ToInt32(this.MatchID));
            string[] statusBoxText = statusBox.Text.Replace("\n", "").Split('\r');

            string text;
            if (statusBoxText.Length >= 8)
            {
                statusBoxText = history.Replace("\n", "").Split('\r');
                text = "";
                for (int i = 0; i < 8; i++)
                    text += statusBoxText[i] + "\n\r";
            } else
                text = history;

            statusBox.Text = text;
            if (turn.Contains("J") && turn.Contains(this.GamerID.ToString()))
            {
                
                btnRollDiceDeactivated.Visible = false;
                btnPauseDeactivate.Visible = false;
                this.btnRollDice_Click(sender, e);
                System.Timers.Timer tmr = new System.Timers.Timer(1000);
                await Task.Delay(2000);
                List<RadioButton> radioButtons = new List<RadioButton>();
                radioButtons.Add(radioButton1);
                radioButtons.Add(radioButton2);
                radioButtons.Add(radioButton3);
                radioButtons.Add(radioButton4);
                radioButtons.Add(radioButton5);
                radioButtons.Add(radioButton6);
                radioButtons.Add(radioButton7);
                radioButtons.Add(radioButton8);
                radioButtons.Add(radioButton9);
                foreach (RadioButton btn in radioButtons)
                {
                    btn.Checked = true;
                    if (lblError.Visible == true && btn != radioButton9)
                        continue;
                    else if (lblError.Visible == true && btn == radioButton9)
                    {
                        this.setBoardData();
                        this.btnPause_Click(sender, e);
                        break;
                    }
                    else
                    {
                        this.setBoardData();
                        this.btnMoviment_Click(sender, e);
                        this.btnPause_Click(sender, e);
                        break;
                    }
                }
                
            }
            else
            {
                btnRollDiceDeactivated.Visible = true;
                btnPauseDeactivate.Visible = true;
                this.setBoardData();
            }
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

        private void clearBoard()
        {
            if (this.pbGamersPositions != null)
            {
                foreach (PictureBox value in this.pbGamersPositions)
                {
                    pbBackground.Controls.Remove(value);
                }
            }
        }

        private void setBoardData()
        {
            string boardData = Jogo.ExibirTabuleiro(Convert.ToInt32(MatchID));
            string[] lines = boardData.Replace("\r", "").Split('\n');
            string[,] board = new string[lines.Length, 4];
            this.clearBoard();
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
            this.pbGamersPositions[i].Visible = false;
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

        private void permuteDices()
        {
            this.Permutations.Clear();
            var Dices1 =  Enumerable.Range(0, this.Dices.GetLength(0))
                            .Select(row => Enumerable.Range(0, this.Dices.GetLength(1))
                            .Select(col => this.Dices[row, col]).ToList()).ToList();
            radioButton1.Checked = false;
            for (int i = 0; i < Dices1.Count; i++)
            {
                var Dices2 = Dices1.GetRange(i, Dices1.Count - i);
                for (int j = 0; j < Dices2.Count; j++)
                {
                    if (Dices1[i][0] != Dices2[j][0])
                    {
                        Permutation inPermutation = new Permutation();
                        inPermutation.setter(Dices1[i], Dices2[j]);
                        this.Permutations.Add(inPermutation);
                    }
                }
            }
            int checkBoxNumber = 1;
            string text = "";
            ;
            foreach (Permutation out_permutation in this.Permutations)
            {
                foreach (Permutation in_permutation in this.Permutations)
                {
                    if (in_permutation.idDice1 != out_permutation.idDice1 &&
                        in_permutation.idDice2 != out_permutation.idDice2 &&
                        in_permutation.idDice1 != out_permutation.idDice2)
                    {
                        Options options1 = new Options();
                        List<Permutation> optionsPermutation1 = new List<Permutation>();
                        Options options2 = new Options();
                        List<Permutation> optionsPermutation2 = new List<Permutation>();
                        Options options3 = new Options();
                        List<Permutation> optionsPermutation3 = new List<Permutation>();

                        if (checkBoxNumber == 1)
                        {
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(out_permutation.diceSum);
                            radioButton1.Text = text;
                            optionsPermutation1.Add(in_permutation);
                            optionsPermutation1.Add(out_permutation);
                            options1.setter(optionsPermutation1, text);
                            this.Options.Add(options1);

                            Permutation clonedPermutation = (Permutation)out_permutation.Clone();
                            clonedPermutation.diceSum = 0;
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(clonedPermutation.diceSum);
                            radioButton4.Text = text;
                            optionsPermutation2.Add(in_permutation);
                            optionsPermutation2.Add(clonedPermutation);
                            options2.setter(optionsPermutation2, text);
                            this.Options.Add(options2);

                            Permutation clonedRightPermutation = (Permutation)in_permutation.Clone();
                            clonedRightPermutation.diceSum = 0;
                            text = Convert.ToString(out_permutation.diceSum) + " e " +
                                Convert.ToString(clonedRightPermutation.diceSum);
                            radioButton7.Text = text;
                            optionsPermutation3.Add(out_permutation);
                            optionsPermutation3.Add(clonedRightPermutation);
                            options3.setter(optionsPermutation3, text);
                            this.Options.Add(options3);
                        }
                        else if (checkBoxNumber == 2)
                        {
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(out_permutation.diceSum);
                            radioButton2.Text = text;
                            optionsPermutation1.Add(in_permutation);
                            optionsPermutation1.Add(out_permutation);
                            options1.setter(optionsPermutation1, text);
                            this.Options.Add(options1);

                            Permutation clonedPermutation = (Permutation)out_permutation.Clone();
                            clonedPermutation.diceSum = 0;
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(clonedPermutation.diceSum);
                            radioButton5.Text = text;
                            optionsPermutation2.Add(in_permutation);
                            optionsPermutation2.Add(clonedPermutation);
                            options2.setter(optionsPermutation2, text);
                            this.Options.Add(options2);

                            Permutation clonedRightPermutation = (Permutation)in_permutation.Clone();
                            clonedRightPermutation.diceSum = 0;
                            text = Convert.ToString(out_permutation.diceSum) + " e " +
                                Convert.ToString(clonedRightPermutation.diceSum);
                            radioButton8.Text = text;
                            optionsPermutation3.Add(out_permutation);
                            optionsPermutation3.Add(clonedRightPermutation);
                            options3.setter(optionsPermutation3, text);
                            this.Options.Add(options3);
                        }
                        else if (checkBoxNumber == 3)
                        {
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(out_permutation.diceSum);
                            radioButton3.Text = text;
                            optionsPermutation1.Add(in_permutation);
                            optionsPermutation1.Add(out_permutation);
                            options1.setter(optionsPermutation1, text);
                            this.Options.Add(options1);

                            Permutation clonedPermutation = (Permutation)out_permutation.Clone();
                            clonedPermutation.diceSum = 0;
                            text = Convert.ToString(in_permutation.diceSum) + " e " +
                                Convert.ToString(clonedPermutation.diceSum);
                            radioButton6.Text = text;
                            optionsPermutation2.Add(in_permutation);
                            optionsPermutation2.Add(clonedPermutation);
                            options2.setter(optionsPermutation2, text);
                            this.Options.Add(options2);

                            Permutation clonedRightPermutation = (Permutation)in_permutation.Clone();
                            clonedRightPermutation.diceSum = 0;
                            text = Convert.ToString(out_permutation.diceSum) + " e " +
                                Convert.ToString(clonedRightPermutation.diceSum);
                            radioButton9.Text = text;
                            optionsPermutation3.Add(out_permutation);
                            optionsPermutation3.Add(clonedRightPermutation);
                            options3.setter(optionsPermutation3, text);
                            this.Options.Add(options3);
                        }
                        else
                            break;
                        checkBoxNumber++;
                    }
                }
            }
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            statusBox.Visible = true;
            //string rollDice = "11\r\n26\r\n35\r\n44\r\n";
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
                permuteDices();
                btnMovimentDeactivate.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                lblOptions.Visible = true;
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

        private (string, string) getMoviment()
        {
            string movimentValue = "";
            string movimentDices = "";
            Options choseOption = new Options();
            string checkedValue;
            if (radioButton1.Checked)
                checkedValue = radioButton1.Text;
            else if (radioButton2.Checked)
                checkedValue = radioButton2.Text;
            else if(radioButton3.Checked)
                checkedValue = radioButton3.Text;
            else if (radioButton4.Checked)
                checkedValue = radioButton4.Text;
            else if (radioButton5.Checked)
                checkedValue = radioButton5.Text;
            else if(radioButton6.Checked)
                checkedValue = radioButton6.Text;
            else if (radioButton7.Checked)
                checkedValue = radioButton7.Text;
            else if (radioButton8.Checked)
                checkedValue = radioButton8.Text;
            else
                checkedValue = radioButton9.Text;

            foreach (Options option in this.Options)
            {
                if (option.options == checkedValue)
                {
                    choseOption = option;
                    break;
                }
            }
            
            foreach (var permutation in choseOption.permutations)
            {
                string value = "";
                if (permutation.diceSum.ToString() == "10")
                    value = "A";
                else if (permutation.diceSum.ToString() == "11")
                    value = "B";
                else if (permutation.diceSum.ToString() == "12")
                    value = "C";
                else
                    value = permutation.diceSum.ToString();

                movimentValue += value;
                movimentDices += permutation.idDice1.ToString() + permutation.idDice2.ToString();
            }

            return (movimentValue, movimentDices);
        }

        private void btnMoviment_Click(object sender, EventArgs e)
        {
            
            (string movimentValue, string movimentDicesOrder) = this.getMoviment();
            lblError.Visible = false;
            statusBox.Visible = true;
            string movimentReturn = "";
            if (movimentValue != "" && movimentDicesOrder != "")
                movimentReturn = Jogo.Mover(this.GamerID, this.Password, movimentDicesOrder, movimentValue);
            else
                movimentReturn = "ERRO: Trilha completa!";

            ;

            if (movimentReturn.Contains("ERRO"))
            {
                lblError.Text = movimentReturn;
                lblError.Visible = true;
                statusBox.Visible = false;
                btnMoviment.Visible = true;
                lblOptions.Visible = true;
            } else
            {
                btnMovimentDeactivate.Visible = true;
                btnMoviment.Visible = false;
                resetGamersPosition();
                this.resetDices();
                setBoardData();
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                lblOptions.Visible = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            string pause = Jogo.Parar(this.GamerID, this.Password);
            if (pause.Contains("ERRO"))
            {
                lblError.Text = pause;
                lblError.Visible = true;
            }
            else
            {
                btnMovimentDeactivate.Visible = true;
                lblError.Visible = false;
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
                pb4.Visible = false;
                pb5.Visible = false;
                pb6.Visible = false;
                statusBox.Visible = true;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                lblOptions.Visible = false;
            }
            
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

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            btnMovimentDeactivate.Visible = false;
            btnMoviment.Visible = true;
        }

    }
}
