namespace PostawNaMilion
{
    partial class ChooseCategory
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            labelTimer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(275, 98);
            label1.Name = "label1";
            label1.Size = new Size(670, 202);
            label1.TabIndex = 1;
            label1.Text = "Wybierz kategorię\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(432, 350);
            button1.Name = "button1";
            button1.Size = new Size(394, 106);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(432, 496);
            button2.Name = "button2";
            button2.Size = new Size(394, 106);
            button2.TabIndex = 3;
            button2.Text = "Y";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 517);
            label2.Name = "label2";
            label2.Size = new Size(242, 46);
            label2.TabIndex = 4;
            label2.Text = "Czas na wybór kategorii";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTimer
            // 
            labelTimer.Anchor = AnchorStyles.None;
            labelTimer.BackColor = Color.FromArgb(255, 255, 192);
            labelTimer.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimer.Location = new Point(30, 563);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(242, 80);
            labelTimer.TabIndex = 5;
            labelTimer.Text = "00:15";
            labelTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChooseCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(labelTimer);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ChooseCategory";
            Size = new Size(1230, 660);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label labelTimer;
    }
}
