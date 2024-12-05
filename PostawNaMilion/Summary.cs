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
    public partial class Summary : UserControl
    {
        int timeToNextScreen = 0;
        List<int> _losts;
        int amountWon;

        public Summary(List<int> losts)
        {
            _losts = losts;
            InitializeComponent();

            for (int i = 0; i < losts.Count; i++)
            {
                if (losts[i] > 0)
                {
                    tableLayoutPanel1.Controls.Add(new PictureBox() {
                        BackgroundImage = Image.FromFile("C:/Users/Malwina/source/repos/PostawNaMilion/smutek.png"),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Size = new Size(140, 140),
                        Anchor = AnchorStyles.None }, 
                        i, 1);
                    tableLayoutPanel1.Controls.Add(new Label()
                    {
                        Text = "-" + losts[i],
                        Anchor = AnchorStyles.None,
                        Font = new Font("Verdana", 12.5F, FontStyle.Regular, GraphicsUnit.Point)},
                    i, 2);
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(new PictureBox() { 
                        BackgroundImage = Image.FromFile("C:/Users/Malwina/source/repos/PostawNaMilion/usmiech.png"), 
                        BackgroundImageLayout = ImageLayout.Stretch, Size = new Size(140, 140), 
                        Anchor = AnchorStyles.None }, 
                    i, 1);
                }
            }
            InputData.counter++;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeToNextScreen++;
            if (timeToNextScreen == 10)
            {
                if (InputData.counter <= 8 && _losts.Sum() < 1000000)
                {
                    var form = (Form1)this.Parent.Parent;
                    form.GoToSecondScreen();
                }
                else
                {
                    var form = (Form1)this.Parent.Parent;
                    amountWon = 1000000 - _losts.Sum();
                    form.GoToEndScreen(amountWon);
                }
                
            }
        }
    }
}
