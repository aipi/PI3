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
        public Game(int id, string gamerName, string gamerColor, string gamerPassword)
        {
            int GamerID = id;
            string GamerName = gamerName;
            string GamerColor = gamerColor;
            string GamerPassword = gamerPassword;
            InitializeComponent();
            label1.Text = GamerID + " " + GamerName + " " + GamerColor + " " + GamerPassword;
        }
    }
}
