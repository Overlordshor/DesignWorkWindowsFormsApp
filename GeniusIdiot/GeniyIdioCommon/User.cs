namespace GeniyIdiotCommon
{

    public class User
        {
        public Diagnose Diagnose { get; private set; }
        public string Name { get; }
        public int CountRightAnswer { get; private set; }
        public User(string name)
            {
            this.Name = name;
            CountRightAnswer = 0;
            }
        public User()
        {
            Name = "Неизвестно";
        }
       
        public void AddRightAnswer()
        {
            CountRightAnswer++;
        }
        public void SetDiagnose(Diagnose diagnose)
        {
            Diagnose = diagnose;
        }
    }
}