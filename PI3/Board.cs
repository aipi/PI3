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
    public partial class Board : Form
    {
        private string[,] boardData;
        public Board(string rawBoardData)
        {
            InitializeComponent();
            this.setBoardData(rawBoardData);
        }

        private void setBoardData(string rawBoardData)
        {
            string[] lines = rawBoardData.Replace("\r", "").Split('\n');
            this.boardData = new string[lines.Length, 4];

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i] != "")
                {
                    string value = lines[i];
                    string[] values = value.Split(',');
                    for (int j = 0; j < values.Length; j++)
                    {
                        this.boardData[i, j] = values[j];
                    }
                }
            }
            Console.WriteLine(lines);
        }

        private void showBoard(int i, int j)
        {
        }
    }
}
