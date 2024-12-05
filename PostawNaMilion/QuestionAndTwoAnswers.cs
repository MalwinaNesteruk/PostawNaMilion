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
    public partial class QuestionAndTwoAnswers : UserControl
    {
        bool flag = true;
        int timerTime = 0;
        int timeToAnswer = 59;
        int amountToBeAllocated = 1000000;
        int amountA = 0;
        int amountB = 0;
        int amountToBeAddedOrDeducted = 25000;
        string _rightAnswer;
        int remainingAmount = 1000000;
        int lostAmount;

        public QuestionAndTwoAnswers(Question question, string rightAnswer, int amountLeft)
        {
            remainingAmount = amountLeft;
            amountToBeAllocated = amountLeft;
            _rightAnswer = rightAnswer;
            InitializeComponent();
            label6.Text = "Kwota: " + remainingAmount.ToString() + " zł";
            label7.Text = "Do rozłożenia: " + amountToBeAllocated.ToString() + " zł";
            label1.Text = question.QuestionText;
            labelAnswerA.Text = question.Variants[0];
            labelAnswerB.Text = question.Variants[1];
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                timerTime++;
                if (timerTime == 10)
                {
                    labelMoneyForA.Visible = true;
                    labelMoneyForB.Visible = true;
                    buttonMinusA.Visible = true;
                    buttonMinusB.Visible = true;
                    buttonPlusA.Visible = true;
                    buttonPlusB.Visible = true;
                    labelTimer.Visible = true;
                }
                else if (timerTime == 11)
                {
                    labelTimer.Text = "01:00";
                    flag = false;
                    timerTime = 0;
                }
            }
            else
            {
                labelTimer.Text = "00" + ":" + timeToAnswer.ToString("00");
                timeToAnswer--;
                if (timeToAnswer == -2)
                {
                    buttonPlusEnabledFalse();
                    buttonMinusEnabledFalse();
                    buttonStopTimer.Visible = false;
                    labelTimer.Visible = false;
                }

                if (timeToAnswer == -7)
                {
                    labelAnswerA.BackColor = Color.Red;
                    labelAnswerB.BackColor = Color.Red;

                    if (labelAnswerA.Text == _rightAnswer)
                    {
                        labelAnswerA.BackColor = Color.Green;
                        label6.Text = "Kwota: " + amountA.ToString() + " zł";
                        lostAmount = remainingAmount - amountA;
                        remainingAmount = amountA;
                        amountToBeAllocated = amountA;

                    }
                    else
                    {
                        labelAnswerB.BackColor = Color.Green;
                        label6.Text = "Kwota: " + amountB.ToString() + " zł";
                        lostAmount = remainingAmount - amountB;
                        remainingAmount = amountB;
                        amountToBeAllocated = amountB;
                    }
                }

                if (timeToAnswer == -13)
                {
                    var form = (Form1)this.Parent.Parent;
                    form.SetNewAmountLeft(remainingAmount);
                    form.AddNewAmountLost(lostAmount);
                    form.GoToSixthScreen();
                }
            }
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            labelTimer.Visible = false;
            buttonPlusEnabledFalse();
            buttonMinusEnabledFalse();
            buttonStopTimer.Visible = false;
            timeToAnswer = -1;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mutingTheRespectivePlusAndMinusButton();
        }

        private void buttonPlusEnabledFalse()
        {
            buttonPlusA.Enabled = false;
            buttonPlusB.Enabled = false;
        }

        private void buttonMinusEnabledFalse()
        {
            buttonMinusA.Enabled = false;
            buttonMinusB.Enabled = false;
        }

        private void buttonPlusEnabledTrue()
        {
            buttonPlusA.Enabled = true;
            buttonPlusB.Enabled = true;
            buttonStopTimer.Visible = false;
        }

        private void mutingTheRespectivePlusAndMinusButton()
        {
            if (amountA != 0)
            {
                buttonMinusB.Enabled = false;
                buttonPlusB.Enabled = false;
            }
            else if (amountB != 0)
            {
                buttonMinusA.Enabled = false;
                buttonPlusA.Enabled = false;
            }
        }

        private void buttonPlusA_Click(object sender, EventArgs e)
        {
            if (amountToBeAllocated > 0)
            {
                amountA += amountToBeAddedOrDeducted;
                labelMoneyForA.Text = amountA.ToString();

                amountToBeAllocated -= amountToBeAddedOrDeducted;
                label7.Text = "Do rozłożenia:" + Environment.NewLine + amountToBeAllocated.ToString() + " zł";
                buttonMinusA.Enabled = true;
            }
            if (amountToBeAllocated == 0)
            {
                buttonPlusEnabledFalse();
                buttonStopTimer.Visible = true;
            }
        }

        private void buttonMinusA_Click(object sender, EventArgs e)
        {
            if (amountA >= amountToBeAddedOrDeducted)
            {
                amountA -= amountToBeAddedOrDeducted;
                labelMoneyForA.Text = amountA.ToString();

                amountToBeAllocated += amountToBeAddedOrDeducted;
                label7.Text = "Do rozłożenia:" + Environment.NewLine + amountToBeAllocated.ToString() + " zł";
                buttonPlusEnabledTrue();
            }
            if (amountA == 0)
            {
                buttonMinusA.Enabled = false;
            }
        }

        private void buttonPlusB_Click(object sender, EventArgs e)
        {
            if (amountToBeAllocated > 0)
            {
                amountB += amountToBeAddedOrDeducted;
                labelMoneyForB.Text = amountB.ToString();

                amountToBeAllocated -= amountToBeAddedOrDeducted;
                label7.Text = "Do rozłożenia:" + Environment.NewLine + amountToBeAllocated.ToString() + " zł";
                buttonMinusB.Enabled = true;
            }
            if (amountToBeAllocated == 0)
            {
                buttonPlusEnabledFalse();
                buttonStopTimer.Visible = true;
            }
        }

        private void buttonMinusB_Click(object sender, EventArgs e)
        {
            if (amountB >= amountToBeAddedOrDeducted)
            {
                amountB -= amountToBeAddedOrDeducted;
                amountToBeAllocated += amountToBeAddedOrDeducted;
                labelMoneyForB.Text = amountB.ToString();
                label7.Text = "Do rozłożenia:" + Environment.NewLine + amountToBeAllocated.ToString() + " zł";
                buttonPlusEnabledTrue();
            }
            if (amountB == 0)
            {
                buttonMinusB.Enabled = false;
            }
        }
    }
}
