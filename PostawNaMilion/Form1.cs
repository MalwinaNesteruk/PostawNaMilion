using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;

namespace PostawNaMilion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void GoToFirstScreen()
        {
            InputData.losts.Clear();
            InputData.amountLeft = 1000000;
            InputData.counter = 1;
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new WelcomeScreen());
        }

        public void GoToSecondScreen()
        {

            SqlConnection sqlConnObj = new SqlConnection(InputData.connString);

            SqlCommand sqlCmd = new SqlCommand("getRandomTwo", sqlConnObj);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlConnObj.Open();

            List<Question> questionList = new List<Question>();
            using (var reader = sqlCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Question question = new Question
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        CategoryName = reader.GetString(reader.GetOrdinal("kategoria")),
                        QuestionText = reader.GetString(reader.GetOrdinal("pytanie")),
                        Variants = new List<string>()
                        {
                            reader.GetString(reader.GetOrdinal("odpowiedzA")),
                            reader.GetString(reader.GetOrdinal("odpowiedzB")),
                            reader.GetString(reader.GetOrdinal("odpowiedzC")),
                            reader.GetString(reader.GetOrdinal("odpowiedzD")),
                        }
                    };
                    questionList.Add(question);
                }
            }

            sqlConnObj.Close();

            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new ChooseCategory(questionList));
        }

        public void GoToThirdScreen(Question question)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new ChoosenCategory(question));
        }

        public void GoToFourthScreen(Question question)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new OnlyAnswers(question));
        }

        public void GoToFourthScreenWithThreeAnswers(Question question)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new OnlyThreeAnswers(question));
        }

        public void GoToFourthScreenWithTwoAnswers(Question question)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new OnlyTwoAnswers(question));
        }

        public void GoToFifthScreen(Question question, string rightAnswer)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new QuestionAndAnswers(question, rightAnswer, InputData.amountLeft));
        }

        public void GoToFifthScreenWithThreeAnswers(Question question, string rightAnswer)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new QuestionAndThreeAnswers(question, rightAnswer, InputData.amountLeft));
        }

        public void GoToFifthScreenWithTwoAnswers(Question question, string rightAnswer)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new QuestionAndTwoAnswers(question, rightAnswer, InputData.amountLeft));
        }

        public void GoToSixthScreen()
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new Summary(InputData.losts));
        }        
        
        public void GoToEndScreen(int amountWon)
        {
            panel1.Controls[0].Dispose();
            panel1.Controls.Add(new NewGame(amountWon));
        }

        internal void SetNewAmountLeft(int remainingAmount)
        {
            InputData.amountLeft = remainingAmount;
        }

        internal void AddNewAmountLost(int amountLost)
        {
            InputData.losts.Add(amountLost);
        }
    }
}
