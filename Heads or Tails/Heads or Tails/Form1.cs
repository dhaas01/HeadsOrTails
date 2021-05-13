using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heads_or_Tails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowHeads_Click(object sender, EventArgs e)
        {
            headsCoin.Visible = true;
            tailsCoin.Visible = false;
        }

        private void ShowTails_Click(object sender, EventArgs e)
        {
            headsCoin.Visible = false;
            tailsCoin.Visible = true;
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
