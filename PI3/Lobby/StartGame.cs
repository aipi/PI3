using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3.Lobby
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
            btnCreateMatch.MouseEnter += OnMouseEnterBtnCreateMatch;
            btnListMatches.MouseEnter += OnMouseEnterBtnListMatches;
        }

        private void OnMouseEnterBtnCreateMatch(object sender, EventArgs e)
        {
            btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void OnMouseEnterBtnListMatches(object sender, EventArgs e)
        {
            btnListMatches.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {

        }
    }
}
