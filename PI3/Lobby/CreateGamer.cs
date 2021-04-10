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
    public partial class CreateGamer : Form
    {
        public CreateGamer()
        {
            InitializeComponent();
            btnCancel.MouseEnter += this.OnMouseEnterBtnCancel;
            btnCreate.MouseEnter += this.OnMouseEnterBtnCreate;
        }

        private void OnMouseEnterBtnCreate(object sender, EventArgs e)
        {
            btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
        }
        private void OnMouseEnterBtnCancel(object sender, EventArgs e)
        {
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
