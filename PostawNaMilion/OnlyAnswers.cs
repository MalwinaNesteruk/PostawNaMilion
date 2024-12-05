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
    public partial class OnlyAnswers : UserControl
    {
        int timeToNextScreen = 0;
        Question _question;
        string rightAnswer;

        public OnlyAnswers(Question question)
        {
            Random random = new Random();
            _question = question;
            rightAnswer = question.Variants[0];
            question.Variants = question.Variants.OrderBy(x => random.Next()).ToList();
            InitializeComponent();
            label2.Text = question.Variants[0];
            label3.Text = question.Variants[1];
            label4.Text = question.Variants[2];
            label5.Text = question.Variants[3];
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToNextScreen++;
            if (timeToNextScreen == 5)
            {
                var form = (Form1)this.Parent.Parent;
                form.GoToFifthScreen(_question, rightAnswer);
            }
        }
    }
}
