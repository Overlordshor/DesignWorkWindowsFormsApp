namespace GeniyIdiotCommon
{

    public class UserResult
    {
        public string Diagnose { get; set; }
        public string Name { get; set; }
        public int CountRightAnswer { get; set; }
       
        public UserResult(string name, int countRightAnswer, string diagnose)
        {
            Name = name;
            CountRightAnswer = countRightAnswer;
            Diagnose = diagnose;
        }
        public UserResult()
        {
        }
    }
}