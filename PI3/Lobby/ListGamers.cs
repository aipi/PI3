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
    public partial class ListGamers : Form
    {
        public ListGamers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListMatches matchesList = new ListMatches();
            matchesList.Show();
        }
    }
}
