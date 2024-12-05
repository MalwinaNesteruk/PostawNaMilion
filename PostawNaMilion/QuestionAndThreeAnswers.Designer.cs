namespace PostawNaMilion
{
    partial class QuestionAndThreeAnswers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonStopTimer = new Button();
            labelMoneyForB = new Label();
            buttonPlusB = new Button();
            buttonMinusB = new Button();
            labelMoneyForC = new Label();
            buttonPlusC = new Button();
            buttonMinusC = new Button();
            labelMoneyForA = new Label();
            buttonPlusA = new Button();
            buttonMinusA = new Button();
            labelTimer = new Label();
            label7 = new Label();
            label6 = new Label();
            labelAnswerC = new Label();
            labelAnswerB = new Label();
            labelAnswerA = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonStopTimer
            // 
            buttonStopTimer.BackColor = Color.Black;
            buttonStopTimer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStopTimer.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStopTimer.ForeColor = Color.Red;
            buttonStopTimer.Location = new Point(509, 300);
            buttonStopTimer.Name = "buttonStopTimer";
            buttonStopTimer.Size = new Size(209, 106);
            buttonStopTimer.TabIndex = 53;
            buttonStopTimer.Text = "Zatrzymaj zegar";
            buttonStopTimer.UseVisualStyleBackColor = false;
            buttonStopTimer.Visible = false;
            buttonStopTimer.Click += buttonStopTimer_Click_1;
            // 
            // labelMoneyForB
            // 
            labelMoneyForB.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForB.Location = new Point(849, 354);
            labelMoneyForB.Name = "labelMoneyForB";
            labelMoneyForB.Size = new Size(158, 45);
            labelMoneyForB.TabIndex = 49;
            labelMoneyForB.Text = "0";
            labelMoneyForB.TextAlign = ContentAlignment.MiddleCenter;
            labelMoneyForB.Visible = false;
            // 
            // buttonPlusB
            // 
            buttonPlusB.BackColor = Color.Black;
            buttonPlusB.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlusB.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlusB.ForeColor = Color.Red;
            buttonPlusB.Location = new Point(1055, 354);
            buttonPlusB.Name = "buttonPlusB";
            buttonPlusB.Size = new Size(40, 40);
            buttonPlusB.TabIndex = 48;
            buttonPlusB.Text = "+";
            buttonPlusB.UseVisualStyleBackColor = false;
            buttonPlusB.Visible = false;
            buttonPlusB.Click += buttonPlusB_Click_1;
            // 
            // buttonMinusB
            // 
            buttonMinusB.BackColor = Color.Black;
            buttonMinusB.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusB.Enabled = false;
            buttonMinusB.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusB.ForeColor = Color.Red;
            buttonMinusB.Location = new Point(774, 354);
            buttonMinusB.Name = "buttonMinusB";
            buttonMinusB.Size = new Size(40, 40);
            buttonMinusB.TabIndex = 47;
            buttonMinusB.Text = "-";
            buttonMinusB.UseVisualStyleBackColor = false;
            buttonMinusB.Visible = false;
            buttonMinusB.Click += buttonMinusB_Click_1;
            // 
            // labelMoneyForC
            // 
            labelMoneyForC.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForC.Location = new Point(525, 571);
            labelMoneyForC.Name = "labelMoneyForC";
            labelMoneyForC.Size = new Size(158, 45);
            labelMoneyForC.TabIndex = 46;
            labelMoneyForC.Text = "0";
            labelMoneyForC.TextAlign = ContentAlignment.MiddleCenter;
            labelMoneyForC.Visible = false;
            // 
            // buttonPlusC
            // 
            buttonPlusC.BackColor = Color.Black;
            buttonPlusC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlusC.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlusC.ForeColor = Color.Red;
            buttonPlusC.Location = new Point(731, 571);
            buttonPlusC.Name = "buttonPlusC";
            buttonPlusC.Size = new Size(40, 40);
            buttonPlusC.TabIndex = 45;
            buttonPlusC.Text = "+";
            buttonPlusC.UseVisualStyleBackColor = false;
            buttonPlusC.Visible = false;
            buttonPlusC.Click += buttonPlusC_Click_1;
            // 
            // buttonMinusC
            // 
            buttonMinusC.BackColor = Color.Black;
            buttonMinusC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusC.Enabled = false;
            buttonMinusC.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusC.ForeColor = Color.Red;
            buttonMinusC.Location = new Point(450, 571);
            buttonMinusC.Name = "buttonMinusC";
            buttonMinusC.Size = new Size(40, 40);
            buttonMinusC.TabIndex = 44;
            buttonMinusC.Text = "-";
            buttonMinusC.UseVisualStyleBackColor = false;
            buttonMinusC.Visible = false;
            buttonMinusC.Click += buttonMinusC_Click_1;
            // 
            // labelMoneyForA
            // 
            labelMoneyForA.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForA.Location = new Point(210, 354);
            labelMoneyForA.Name = "labelMoneyForA";
            labelMoneyForA.Size = new Size(158, 45);
            labelMoneyForA.TabIndex = 43;
            labelMoneyForA.Text = "0";
            labelMoneyForA.TextAlign = ContentAlignment.MiddleCenter;
            labelMoneyForA.Visible = false;
            // 
            // buttonPlusA
            // 
            buttonPlusA.BackColor = Color.Black;
            buttonPlusA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlusA.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlusA.ForeColor = Color.Red;
            buttonPlusA.Location = new Point(416, 354);
            buttonPlusA.Name = "buttonPlusA";
            buttonPlusA.Size = new Size(40, 40);
            buttonPlusA.TabIndex = 42;
            buttonPlusA.Text = "+";
            buttonPlusA.UseVisualStyleBackColor = false;
            buttonPlusA.Visible = false;
            buttonPlusA.Click += buttonPlusA_Click_1;
            // 
            // buttonMinusA
            // 
            buttonMinusA.BackColor = Color.Black;
            buttonMinusA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusA.Enabled = false;
            buttonMinusA.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusA.ForeColor = Color.Red;
            buttonMinusA.Location = new Point(135, 354);
            buttonMinusA.Name = "buttonMinusA";
            buttonMinusA.Size = new Size(40, 40);
            buttonMinusA.TabIndex = 41;
            buttonMinusA.Text = "-";
            buttonMinusA.UseVisualStyleBackColor = false;
            buttonMinusA.Visible = false;
            buttonMinusA.Click += buttonMinusA_Click_1;
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.BackColor = Color.FromArgb(192, 192, 255);
            labelTimer.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(486, 1);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(270, 99);
            labelTimer.TabIndex = 40;
            labelTimer.Text = "START!";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            labelTimer.Visible = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.FromArgb(192, 192, 255);
            label7.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(959, 10);
            label7.Name = "label7";
            label7.Size = new Size(270, 99);
            label7.TabIndex = 39;
            label7.Text = "Do rozłożenia: 1000000 zł";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(192, 192, 255);
            label6.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(2, 10);
            label6.Name = "label6";
            label6.Size = new Size(324, 77);
            label6.TabIndex = 38;
            label6.Text = "Kwota: 1000000 zł";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerC
            // 
            labelAnswerC.Anchor = AnchorStyles.None;
            labelAnswerC.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerC.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerC.Location = new Point(439, 473);
            labelAnswerC.Name = "labelAnswerC";
            labelAnswerC.Size = new Size(344, 83);
            labelAnswerC.TabIndex = 36;
            labelAnswerC.Text = "C";
            labelAnswerC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerB
            // 
            labelAnswerB.Anchor = AnchorStyles.None;
            labelAnswerB.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerB.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerB.Location = new Point(761, 257);
            labelAnswerB.Name = "labelAnswerB";
            labelAnswerB.Size = new Size(344, 83);
            labelAnswerB.TabIndex = 35;
            labelAnswerB.Text = "B";
            labelAnswerB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerA
            // 
            labelAnswerA.Anchor = AnchorStyles.None;
            labelAnswerA.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerA.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerA.Location = new Point(123, 257);
            labelAnswerA.Name = "labelAnswerA";
            labelAnswerA.Size = new Size(344, 83);
            labelAnswerA.TabIndex = 34;
            labelAnswerA.Text = "A";
            labelAnswerA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(136, 108);
            label1.Name = "label1";
            label1.Size = new Size(960, 118);
            label1.TabIndex = 33;
            label1.Text = "Pytanie";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // QuestionAndThreeAnswers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(buttonStopTimer);
            Controls.Add(labelMoneyForB);
            Controls.Add(buttonPlusB);
            Controls.Add(buttonMinusB);
            Controls.Add(labelMoneyForC);
            Controls.Add(buttonPlusC);
            Controls.Add(buttonMinusC);
            Controls.Add(labelMoneyForA);
            Controls.Add(buttonPlusA);
            Controls.Add(buttonMinusA);
            Controls.Add(labelTimer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelAnswerC);
            Controls.Add(labelAnswerB);
            Controls.Add(labelAnswerA);
            Controls.Add(label1);
            Name = "QuestionAndThreeAnswers";
            Size = new Size(1230, 660);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStopTimer;
        private Label labelMoneyForB;
        private Button buttonPlusB;
        private Button buttonMinusB;
        private Label labelMoneyForC;
        private Button buttonPlusC;
        private Button buttonMinusC;
        private Label labelMoneyForA;
        private Button buttonPlusA;
        private Button buttonMinusA;
        private Label labelTimer;
        private Label label7;
        private Label label6;
        private Label labelAnswerC;
        private Label labelAnswerB;
        private Label labelAnswerA;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
