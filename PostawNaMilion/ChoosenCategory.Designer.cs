namespace PostawNaMilion
{
    partial class ChoosenCategory
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
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 82);
            label1.Name = "label1";
            label1.Size = new Size(670, 202);
            label1.TabIndex = 6;
            label1.Text = "Kategoria";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.BackColor = Color.Black;
            label2.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(397, 396);
            label2.Name = "label2";
            label2.Size = new Size(394, 106);
            label2.TabIndex = 8;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChoosenCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChoosenCategory";
            Size = new Size(1230, 660);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}
