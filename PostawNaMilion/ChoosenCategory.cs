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
    public partial class ChoosenCategory : UserControl
    {
        private readonly Question _question;
        private int timeToNextScreen = 0;

        public ChoosenCategory(Question question)
        {
            InitializeComponent();
            _question = question;
            label2.Text = _question.CategoryName;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToNextScreen++;
            if (timeToNextScreen == 2)
            {
                var form = (Form1)this.Parent.Parent;
                if (InputData.counter <= 4)
                {
                    form.GoToFourthScreen(_question);
                }
                else if (InputData.counter >= 5 && InputData.counter <= 7)
                {
                    form.GoToFourthScreenWithThreeAnswers(_question);
                }
                else
                {
                    form.GoToFourthScreenWithTwoAnswers(_question);
                }
            }
        }
    }
}