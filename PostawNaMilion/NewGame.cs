using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostawNaMilion
{
    public partial class NewGame : UserControl
    {
        public NewGame(int amountWon)
        {
            InitializeComponent();
            label1.Text = amountWon == 0 ? "PRZEGRAŁEŚ!" : "Wygrałeś" + Environment.NewLine + amountWon.ToString() + " zł!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = (Form1)this.Parent.Parent;
            form.GoToFirstScreen();
        }
    }
}
