﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostawNaMilion
{
    public partial class OnlyTwoAnswers : UserControl
    {
        int timeToNextScreen = 0;
        Question _question;
        string rightAnswer;

        public OnlyTwoAnswers(Question question)
        {
            Random random = new Random();
            _question = question;
            rightAnswer = question.Variants[0];
            int deletedItem = random.Next(1, 4);
            question.Variants.RemoveAt(deletedItem);
            deletedItem = random.Next(1, 3);
            question.Variants.RemoveAt(deletedItem);
            question.Variants = question.Variants.OrderBy(x => random.Next()).ToList();
            InitializeComponent();
            label2.Text = question.Variants[0];
            label3.Text = question.Variants[1];
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToNextScreen++;
            if (timeToNextScreen == 5)
            {
                var form = (Form1)this.Parent.Parent;
                form.GoToFifthScreenWithTwoAnswers(_question, rightAnswer);
            }
        }
    }
}
