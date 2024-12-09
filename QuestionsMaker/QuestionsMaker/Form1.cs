using System.Data;
using System.Data.SqlClient;

namespace QuestionsMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string? Validate()
        {
            if (string.IsNullOrEmpty(textBoxCategory.Text))
            {
                return "Pole 'Nazwa kategorii' jest puste.";
            }
            else if (string.IsNullOrEmpty(textBoxQuestion.Text))
            {
                return "Pole 'Treœæ pytania' jest puste.";
            }
            else if (string.IsNullOrEmpty(textBoxA.Text))
            {
                return "Pole 'Wariant A' jest puste.";
            }
            else if (string.IsNullOrEmpty(textBoxB.Text))
            {
                return "Pole 'Wariant B' jest puste.";
            }
            else if (string.IsNullOrEmpty(textBoxC.Text))
            {
                return "Pole 'Wariant C' jest puste.";
            }
            else if (string.IsNullOrEmpty(textBoxD.Text))
            {
                return "Pole 'Wariant D' jest puste.";
            }

            else if (textBoxCategory.Text.Length > 200)
            {
                return "Treœæ wprowadzona w polu 'Nazwa kategorii' jest za d³uga. Limit znaków to 200.";
            }
            else if (textBoxQuestion.Text.Length > 2000)
            {
                return "Treœæ wprowadzona w polu 'Treœæ pytania' jest za d³uga. Limit znaków to 2000.";
            }
            else if (textBoxA.Text.Length > 200)
            {
                return "Treœæ wprowadzona w polu 'Wariant A' jest za d³uga. Limit znaków to 200.";
            }
            else if (textBoxB.Text.Length > 200)
            {
                return "Treœæ wprowadzona w polu 'Wariant B' jest za d³uga. Limit znaków to 200.";
            }
            else if (textBoxC.Text.Length > 200)
            {
                return "Treœæ wprowadzona w polu 'Wariant C' jest za d³uga. Limit znaków to 200.";
            }
            else if (textBoxD.Text.Length > 200)
            {
                return "Treœæ wprowadzona w polu 'Wariant D' jest za d³uga. Limit znaków to 200.";
            }
            else
            {
                return null;
            }
        }

        private void buttonAddToDatabaseOfQuestions_Click(object sender, EventArgs e)
        {
            string newInfo = Validate();

            if (!string.IsNullOrEmpty(newInfo))
            {
                MessageBox.Show(newInfo);
            }
            else
            {
                SqlConnection sqlConnObj = new SqlConnection();
                SqlCommand sqlCmd = new SqlCommand();
                sqlConnObj.ConnectionString = "Data Source=localhost;Initial Catalog=Pytania;Integrated Security=True;Connect Timeout=30";
                sqlConnObj.Open();

                sqlCmd.Connection = sqlConnObj;
                sqlCmd.CommandText = @"INSERT INTO Pytanie (kategoria, pytanie, odpowiedzA, odpowiedzB, odpowiedzC, odpowiedzD) VALUES (@kategoria, @pytanie, @odpowiedzA, @odpowiedzB, @odpowiedzC, @odpowiedzD)";
                sqlCmd.Parameters.Add("@kategoria", SqlDbType.VarChar).Value = textBoxCategory.Text;
                sqlCmd.Parameters.Add("@pytanie", SqlDbType.VarChar).Value = textBoxQuestion.Text;
                sqlCmd.Parameters.Add("@odpowiedzA", SqlDbType.VarChar).Value = textBoxA.Text;
                sqlCmd.Parameters.Add("@odpowiedzB", SqlDbType.VarChar).Value = textBoxB.Text;
                sqlCmd.Parameters.Add("@odpowiedzC", SqlDbType.VarChar).Value = textBoxC.Text;
                sqlCmd.Parameters.Add("@odpowiedzD", SqlDbType.VarChar).Value = textBoxD.Text;

                sqlCmd.ExecuteNonQuery();
                sqlConnObj.Close();

                textBoxCategory.Clear();
                textBoxQuestion.Clear();
                textBoxA.Clear();
                textBoxB.Clear();
                textBoxC.Clear();
                textBoxD.Clear();

                MessageBox.Show("Pytanie zosta³o dodane do bazy.");
            } 
        }
    }
}
