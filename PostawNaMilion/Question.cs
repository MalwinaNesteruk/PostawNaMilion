namespace PostawNaMilion
{
    public class Question
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string QuestionText { get; set; }
        public List<string> Variants { get; set; }
        public bool IsUsed { get; set; }
    }
}