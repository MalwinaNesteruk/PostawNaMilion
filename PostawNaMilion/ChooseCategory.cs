using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostawNaMilion
{
    public partial class ChooseCategory : UserControl
    {
        int timeToChooseCategory = 14;
        Random rand = new Random();
        List<Question> _questionList = new List<Question>();

        public ChooseCategory(List<Question> questionList)
        {
            InitializeComponent();
            _questionList = questionList;
            button1.Text = questionList[0].CategoryName;
            button2.Text = questionList[1].CategoryName;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = "00" + ":" + timeToChooseCategory.ToString("00");
            timeToChooseCategory--;

            if (timeToChooseCategory == -2)
            {
                int categoryNumber = rand.Next(1, 3);
                if (categoryNumber == 1)
                {
                    var form = (Form1)this.Parent.Parent;
                    form.GoToThirdScreen(_questionList[0]);
                }
                else
                {
                    var form = (Form1)this.Parent.Parent;
                    form.GoToThirdScreen(_questionList[1]);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = (Form1)this.Parent.Parent;
            form.GoToThirdScreen(_questionList[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = (Form1)this.Parent.Parent;
            form.GoToThirdScreen(_questionList[1]);
        }


    }
}
