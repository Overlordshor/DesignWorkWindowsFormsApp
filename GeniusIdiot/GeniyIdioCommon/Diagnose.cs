using System.Collections.Generic;

namespace GeniyIdiotCommon
{
    public class Diagnose
    {
        public string Name;
        public Diagnose(string diagnose)
        {
            Name = diagnose;
        }
        public static List<Diagnose> GetDiagnoses()
        {
            List<Diagnose> diagnose = new List<Diagnose>()
            {
                new Diagnose("Идиот"),
                new Diagnose("Кретин"),
                new Diagnose("Дурак"),
                new Diagnose("Нормальный"),
                new Diagnose("Талант"),
                new Diagnose("Гений")
            };
            return diagnose;
        }
            public static int CalculateValueDiagnose(int cntRightAnswer, int cntDiagnose, int cntQuestion)
            {
                int valueRightAnswer = cntRightAnswer
                    * (cntDiagnose - 1)
                    / cntQuestion;
            return valueRightAnswer;
            }
        }
}