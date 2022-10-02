namespace QuestionsAPI
{
    public class User
    {
        public int Id;
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class QAnswers
    {
        public int Id { get; set; }
        public string Q { get; set; }
        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; }
        public string A4 { get; set; }

    }
}