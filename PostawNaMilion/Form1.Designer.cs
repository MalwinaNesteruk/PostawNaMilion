namespace PostawNaMilion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            welcomeScreen1 = new WelcomeScreen();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(welcomeScreen1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 660);
            panel1.TabIndex = 0;
            // 
            // welcomeScreen1
            // 
            welcomeScreen1.BackgroundImage = (Image)resources.GetObject("welcomeScreen1.BackgroundImage");
            welcomeScreen1.BackgroundImageLayout = ImageLayout.Stretch;
            welcomeScreen1.Dock = DockStyle.Fill;
            welcomeScreen1.Location = new Point(0, 0);
            welcomeScreen1.Name = "welcomeScreen1";
            welcomeScreen1.Size = new Size(1230, 660);
            welcomeScreen1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 661);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private WelcomeScreen welcomeScreen1;
    }
}
