namespace PostawNaMilion
{
    partial class QuestionAndAnswers
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
            labelAnswerD = new Label();
            labelAnswerC = new Label();
            labelAnswerB = new Label();
            labelAnswerA = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelTimer = new Label();
            buttonMinusA = new Button();
            buttonPlusA = new Button();
            labelMoneyForA = new Label();
            labelMoneyForC = new Label();
            buttonPlusC = new Button();
            buttonMinusC = new Button();
            labelMoneyForB = new Label();
            buttonPlusB = new Button();
            buttonMinusB = new Button();
            labelMoneyForD = new Label();
            buttonPlusD = new Button();
            buttonMinusD = new Button();
            buttonStopTimer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelAnswerD
            // 
            labelAnswerD.Anchor = AnchorStyles.None;
            labelAnswerD.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerD.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerD.Location = new Point(762, 471);
            labelAnswerD.Name = "labelAnswerD";
            labelAnswerD.Size = new Size(344, 83);
            labelAnswerD.TabIndex = 16;
            labelAnswerD.Text = "D";
            labelAnswerD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerC
            // 
            labelAnswerC.Anchor = AnchorStyles.None;
            labelAnswerC.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerC.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerC.Location = new Point(124, 471);
            labelAnswerC.Name = "labelAnswerC";
            labelAnswerC.Size = new Size(344, 83);
            labelAnswerC.TabIndex = 15;
            labelAnswerC.Text = "C";
            labelAnswerC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerB
            // 
            labelAnswerB.Anchor = AnchorStyles.None;
            labelAnswerB.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerB.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerB.Location = new Point(762, 256);
            labelAnswerB.Name = "labelAnswerB";
            labelAnswerB.Size = new Size(344, 83);
            labelAnswerB.TabIndex = 14;
            labelAnswerB.Text = "B";
            labelAnswerB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAnswerA
            // 
            labelAnswerA.Anchor = AnchorStyles.None;
            labelAnswerA.BackColor = Color.FromArgb(255, 255, 192);
            labelAnswerA.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswerA.Location = new Point(124, 256);
            labelAnswerA.Name = "labelAnswerA";
            labelAnswerA.Size = new Size(344, 83);
            labelAnswerA.TabIndex = 13;
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
            label1.TabIndex = 12;
            label1.Text = "Pytanie";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.BackColor = Color.FromArgb(192, 192, 255);
            label6.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(324, 77);
            label6.TabIndex = 17;
            label6.Text = "Kwota: 1000000 zł";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.BackColor = Color.FromArgb(192, 192, 255);
            label7.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(975, 9);
            label7.Name = "label7";
            label7.Size = new Size(252, 99);
            label7.TabIndex = 18;
            label7.Text = "Do rozłożenia: 1000000 zł";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.BackColor = Color.FromArgb(192, 192, 255);
            labelTimer.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(487, 0);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(270, 99);
            labelTimer.TabIndex = 19;
            labelTimer.Text = "START!";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            labelTimer.Visible = false;
            // 
            // buttonMinusA
            // 
            buttonMinusA.BackColor = Color.Black;
            buttonMinusA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusA.Enabled = false;
            buttonMinusA.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusA.ForeColor = Color.Red;
            buttonMinusA.Location = new Point(136, 353);
            buttonMinusA.Name = "buttonMinusA";
            buttonMinusA.Size = new Size(40, 40);
            buttonMinusA.TabIndex = 20;
            buttonMinusA.Text = "-";
            buttonMinusA.UseVisualStyleBackColor = false;
            buttonMinusA.Visible = false;
            buttonMinusA.Click += buttonMinusA_Click;
            // 
            // buttonPlusA
            // 
            buttonPlusA.BackColor = Color.Black;
            buttonPlusA.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlusA.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlusA.ForeColor = Color.Red;
            buttonPlusA.Location = new Point(417, 353);
            buttonPlusA.Name = "buttonPlusA";
            buttonPlusA.Size = new Size(40, 40);
            buttonPlusA.TabIndex = 21;
            buttonPlusA.Text = "+";
            buttonPlusA.UseVisualStyleBackColor = false;
            buttonPlusA.Visible = false;
            buttonPlusA.Click += buttonPlusA_Click;
            // 
            // labelMoneyForA
            // 
            labelMoneyForA.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForA.Location = new Point(211, 353);
            labelMoneyForA.Name = "labelMoneyForA";
            labelMoneyForA.Size = new Size(158, 45);
            labelMoneyForA.TabIndex = 22;
            labelMoneyForA.Text = "0";
            labelMoneyForA.TextAlign = ContentAlignment.MiddleCenter;
            labelMoneyForA.Visible = false;
            // 
            // labelMoneyForC
            // 
            labelMoneyForC.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForC.Location = new Point(211, 570);
            labelMoneyForC.Name = "labelMoneyForC";
            labelMoneyForC.Size = new Size(158, 45);
            labelMoneyForC.TabIndex = 25;
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
            buttonPlusC.Location = new Point(417, 570);
            buttonPlusC.Name = "buttonPlusC";
            buttonPlusC.Size = new Size(40, 40);
            buttonPlusC.TabIndex = 24;
            buttonPlusC.Text = "+";
            buttonPlusC.UseVisualStyleBackColor = false;
            buttonPlusC.Visible = false;
            buttonPlusC.Click += buttonPlusC_Click;
            // 
            // buttonMinusC
            // 
            buttonMinusC.BackColor = Color.Black;
            buttonMinusC.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusC.Enabled = false;
            buttonMinusC.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusC.ForeColor = Color.Red;
            buttonMinusC.Location = new Point(136, 570);
            buttonMinusC.Name = "buttonMinusC";
            buttonMinusC.Size = new Size(40, 40);
            buttonMinusC.TabIndex = 23;
            buttonMinusC.Text = "-";
            buttonMinusC.UseVisualStyleBackColor = false;
            buttonMinusC.Visible = false;
            buttonMinusC.Click += buttonMinusC_Click;
            // 
            // labelMoneyForB
            // 
            labelMoneyForB.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForB.Location = new Point(850, 353);
            labelMoneyForB.Name = "labelMoneyForB";
            labelMoneyForB.Size = new Size(158, 45);
            labelMoneyForB.TabIndex = 28;
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
            buttonPlusB.Location = new Point(1056, 353);
            buttonPlusB.Name = "buttonPlusB";
            buttonPlusB.Size = new Size(40, 40);
            buttonPlusB.TabIndex = 27;
            buttonPlusB.Text = "+";
            buttonPlusB.UseVisualStyleBackColor = false;
            buttonPlusB.Visible = false;
            buttonPlusB.Click += buttonPlusB_Click;
            // 
            // buttonMinusB
            // 
            buttonMinusB.BackColor = Color.Black;
            buttonMinusB.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusB.Enabled = false;
            buttonMinusB.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusB.ForeColor = Color.Red;
            buttonMinusB.Location = new Point(775, 353);
            buttonMinusB.Name = "buttonMinusB";
            buttonMinusB.Size = new Size(40, 40);
            buttonMinusB.TabIndex = 26;
            buttonMinusB.Text = "-";
            buttonMinusB.UseVisualStyleBackColor = false;
            buttonMinusB.Visible = false;
            buttonMinusB.Click += buttonMinusB_Click;
            // 
            // labelMoneyForD
            // 
            labelMoneyForD.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoneyForD.Location = new Point(850, 567);
            labelMoneyForD.Name = "labelMoneyForD";
            labelMoneyForD.Size = new Size(158, 45);
            labelMoneyForD.TabIndex = 31;
            labelMoneyForD.Text = "0";
            labelMoneyForD.TextAlign = ContentAlignment.MiddleCenter;
            labelMoneyForD.Visible = false;
            // 
            // buttonPlusD
            // 
            buttonPlusD.BackColor = Color.Black;
            buttonPlusD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPlusD.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlusD.ForeColor = Color.Red;
            buttonPlusD.Location = new Point(1056, 567);
            buttonPlusD.Name = "buttonPlusD";
            buttonPlusD.Size = new Size(40, 40);
            buttonPlusD.TabIndex = 30;
            buttonPlusD.Text = "+";
            buttonPlusD.UseVisualStyleBackColor = false;
            buttonPlusD.Visible = false;
            buttonPlusD.Click += buttonPlusD_Click;
            // 
            // buttonMinusD
            // 
            buttonMinusD.BackColor = Color.Black;
            buttonMinusD.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinusD.Enabled = false;
            buttonMinusD.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinusD.ForeColor = Color.Red;
            buttonMinusD.Location = new Point(775, 567);
            buttonMinusD.Name = "buttonMinusD";
            buttonMinusD.Size = new Size(40, 40);
            buttonMinusD.TabIndex = 29;
            buttonMinusD.Text = "-";
            buttonMinusD.UseVisualStyleBackColor = false;
            buttonMinusD.Visible = false;
            buttonMinusD.Click += buttonMinusD_Click;
            // 
            // buttonStopTimer
            // 
            buttonStopTimer.BackColor = Color.Black;
            buttonStopTimer.BackgroundImageLayout = ImageLayout.Zoom;
            buttonStopTimer.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStopTimer.ForeColor = Color.Red;
            buttonStopTimer.Location = new Point(510, 372);
            buttonStopTimer.Name = "buttonStopTimer";
            buttonStopTimer.Size = new Size(209, 106);
            buttonStopTimer.TabIndex = 32;
            buttonStopTimer.Text = "Zatrzymaj zegar";
            buttonStopTimer.UseVisualStyleBackColor = false;
            buttonStopTimer.Visible = false;
            buttonStopTimer.Click += buttonStopTimer_Click;
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
            // QuestionAndAnswers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(buttonStopTimer);
            Controls.Add(labelMoneyForD);
            Controls.Add(buttonPlusD);
            Controls.Add(buttonMinusD);
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
            Controls.Add(labelAnswerD);
            Controls.Add(labelAnswerC);
            Controls.Add(labelAnswerB);
            Controls.Add(labelAnswerA);
            Controls.Add(label1);
            Name = "QuestionAndAnswers";
            Size = new Size(1230, 660);
            ResumeLayout(false);
        }

        #endregion

        private Label labelAnswerD;
        private Label labelAnswerC;
        private Label labelAnswerB;
        private Label labelAnswerA;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label labelTimer;
        private Button buttonMinusA;
        private Button buttonPlusA;
        private Label labelMoneyForA;
        private Label labelMoneyForC;
        private Button buttonPlusC;
        private Button buttonMinusC;
        private Label labelMoneyForB;
        private Button buttonPlusB;
        private Button buttonMinusB;
        private Label labelMoneyForD;
        private Button buttonPlusD;
        private Button buttonMinusD;
        private Button buttonStopTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
