﻿namespace PostawNaMilion
{
    partial class OnlyThreeAnswers
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(439, 473);
            label4.Name = "label4";
            label4.Size = new Size(344, 83);
            label4.TabIndex = 15;
            label4.Text = "C";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.FromArgb(255, 255, 192);
            label3.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(762, 256);
            label3.Name = "label3";
            label3.Size = new Size(344, 83);
            label3.TabIndex = 14;
            label3.Text = "B";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BackColor = Color.FromArgb(255, 255, 192);
            label2.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 256);
            label2.Name = "label2";
            label2.Size = new Size(344, 83);
            label2.TabIndex = 13;
            label2.Text = "A";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 10);
            label1.Name = "label1";
            label1.Size = new Size(670, 118);
            label1.TabIndex = 12;
            label1.Text = "Odpowiedzi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // OnlyThreeAnswers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OnlyThreeAnswers";
            Size = new Size(1230, 660);
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
