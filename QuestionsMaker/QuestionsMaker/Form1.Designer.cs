namespace QuestionsMaker
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
            label1 = new Label();
            buttonAddToDatabaseOfQuestions = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelCategory = new Label();
            labelQuestion = new Label();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            textBoxA = new TextBox();
            textBoxCategory = new TextBox();
            textBoxQuestion = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            textBoxD = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 9);
            label1.Margin = new Padding(19, 0, 19, 0);
            label1.Name = "label1";
            label1.Size = new Size(1088, 113);
            label1.TabIndex = 0;
            label1.Text = "Stwórz pytanie, które następnie pojawi się w grze \"Postaw na milion\"!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonAddToDatabaseOfQuestions
            // 
            buttonAddToDatabaseOfQuestions.BackColor = Color.Black;
            buttonAddToDatabaseOfQuestions.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddToDatabaseOfQuestions.ForeColor = Color.Red;
            buttonAddToDatabaseOfQuestions.Location = new Point(408, 575);
            buttonAddToDatabaseOfQuestions.Name = "buttonAddToDatabaseOfQuestions";
            buttonAddToDatabaseOfQuestions.Size = new Size(415, 65);
            buttonAddToDatabaseOfQuestions.TabIndex = 1;
            buttonAddToDatabaseOfQuestions.Text = "Dodaj do bazy pytań";
            buttonAddToDatabaseOfQuestions.UseVisualStyleBackColor = false;
            buttonAddToDatabaseOfQuestions.Click += buttonAddToDatabaseOfQuestions_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(labelCategory, 0, 0);
            tableLayoutPanel1.Controls.Add(labelQuestion, 0, 1);
            tableLayoutPanel1.Controls.Add(labelA, 0, 2);
            tableLayoutPanel1.Controls.Add(labelB, 0, 3);
            tableLayoutPanel1.Controls.Add(labelC, 0, 4);
            tableLayoutPanel1.Controls.Add(labelD, 0, 5);
            tableLayoutPanel1.Controls.Add(textBoxA, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxCategory, 1, 0);
            tableLayoutPanel1.Controls.Add(textBoxQuestion, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxB, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxC, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxD, 1, 5);
            tableLayoutPanel1.Location = new Point(41, 148);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1140, 402);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelCategory
            // 
            labelCategory.Anchor = AnchorStyles.None;
            labelCategory.BackColor = Color.FromArgb(255, 255, 192);
            labelCategory.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelCategory.Location = new Point(4, 2);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(447, 55);
            labelCategory.TabIndex = 0;
            labelCategory.Text = "Nazwa kategorii";
            labelCategory.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelQuestion
            // 
            labelQuestion.Anchor = AnchorStyles.None;
            labelQuestion.BackColor = Color.FromArgb(255, 255, 192);
            labelQuestion.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuestion.Location = new Point(4, 64);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(447, 92);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Treść pytania";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            labelA.Anchor = AnchorStyles.None;
            labelA.BackColor = Color.FromArgb(255, 255, 192);
            labelA.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelA.Location = new Point(4, 162);
            labelA.Name = "labelA";
            labelA.Size = new Size(447, 55);
            labelA.TabIndex = 2;
            labelA.Text = "Wariant A\r\n(Należy wpisać prawidłową odpowiedź)";
            labelA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            labelB.Anchor = AnchorStyles.None;
            labelB.BackColor = Color.FromArgb(255, 255, 192);
            labelB.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelB.Location = new Point(4, 222);
            labelB.Name = "labelB";
            labelB.Size = new Size(447, 55);
            labelB.TabIndex = 3;
            labelB.Text = "Wariant B";
            labelB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            labelC.Anchor = AnchorStyles.None;
            labelC.BackColor = Color.FromArgb(255, 255, 192);
            labelC.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelC.Location = new Point(4, 282);
            labelC.Name = "labelC";
            labelC.Size = new Size(447, 55);
            labelC.TabIndex = 4;
            labelC.Text = "Wariant C";
            labelC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelD
            // 
            labelD.Anchor = AnchorStyles.None;
            labelD.BackColor = Color.FromArgb(255, 255, 192);
            labelD.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelD.Location = new Point(4, 343);
            labelD.Name = "labelD";
            labelD.Size = new Size(447, 55);
            labelD.TabIndex = 5;
            labelD.Text = "Wariant D";
            labelD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxA
            // 
            textBoxA.Anchor = AnchorStyles.None;
            textBoxA.BorderStyle = BorderStyle.FixedSingle;
            textBoxA.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxA.Location = new Point(459, 163);
            textBoxA.Multiline = true;
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(678, 54);
            textBoxA.TabIndex = 3;
            // 
            // textBoxCategory
            // 
            textBoxCategory.Anchor = AnchorStyles.None;
            textBoxCategory.BorderStyle = BorderStyle.FixedSingle;
            textBoxCategory.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCategory.Location = new Point(459, 3);
            textBoxCategory.Multiline = true;
            textBoxCategory.Name = "textBoxCategory";
            textBoxCategory.Size = new Size(678, 54);
            textBoxCategory.TabIndex = 1;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Anchor = AnchorStyles.None;
            textBoxQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxQuestion.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuestion.Location = new Point(459, 64);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(678, 92);
            textBoxQuestion.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Anchor = AnchorStyles.None;
            textBoxB.BorderStyle = BorderStyle.FixedSingle;
            textBoxB.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxB.Location = new Point(459, 223);
            textBoxB.Multiline = true;
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(678, 54);
            textBoxB.TabIndex = 4;
            // 
            // textBoxC
            // 
            textBoxC.Anchor = AnchorStyles.None;
            textBoxC.BorderStyle = BorderStyle.FixedSingle;
            textBoxC.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxC.Location = new Point(459, 283);
            textBoxC.Multiline = true;
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(678, 54);
            textBoxC.TabIndex = 5;
            // 
            // textBoxD
            // 
            textBoxD.Anchor = AnchorStyles.None;
            textBoxD.BorderStyle = BorderStyle.FixedSingle;
            textBoxD.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxD.Location = new Point(459, 344);
            textBoxD.Multiline = true;
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(678, 54);
            textBoxD.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(45F, 78F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1234, 661);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonAddToDatabaseOfQuestions);
            Controls.Add(label1);
            Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(19, 16, 19, 16);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonAddToDatabaseOfQuestions;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelCategory;
        private Label labelQuestion;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
        private TextBox textBoxCategory;
        private TextBox textBoxA;
        private TextBox textBoxQuestion;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private TextBox textBoxD;
    }
}
