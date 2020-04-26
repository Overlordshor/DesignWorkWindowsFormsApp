using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppIdiot
{
    class Question
    {
        string text = "Сколько будет два плюс два умноженное на два?";
        int answer = 1;
        public string Print()
        {
            return "Вопрос" + text;
        }
    }
    public class Program
    {
        static string PathToResultDiagnose = "result_diagnos.txt";
        public static void Main()
        {
            Question question = new Question();
            Console.WriteLine(question.Print());
            //List<string> questions = GetQuestion();
            //List<string> answers = RightAnswer();
            //int cntQuestion = questions.Count;
            //int cntRightAnswer = 0;
            //for (int i = 0; i < cntQuestion; i++)
            //{
            //    Console.WriteLine("Вопрос №" + (i + 1));

            //    int randomI = GetRandom(questions.Count);
            //    Console.WriteLine(questions[randomI]);

            //    string userAnswer = Console.ReadLine();
            //    if (userAnswer == answers[randomI])
            //    {
            //        cntRightAnswer++;
            //    }
            //    questions.RemoveAt(randomI);
            //    answers.RemoveAt(randomI);

            //}
            //var diagnos = CalculateDiagnos(cntRightAnswer, cntQuestion);
            //Console.Write("Ваш диагноз" + " " + AddName() + " ");
            //Console.WriteLine(diagnos);
            //SaveResulDiagnos(diagnos);
            //var data = LoadResultDiagnos(PathToResultDiagnose);
            //Console.WriteLine(data);
            //Console.ReadKey();
        }

        private static void SaveResulDiagnos(string diagnos)
        {
            StreamWriter writer = new StreamWriter(PathToResultDiagnose, true, Encoding.UTF8);
            writer.WriteLine(diagnos);
            writer.Close();
        }

        static string LoadResultDiagnos(string path)
        {
            StreamReader reader = new StreamReader(path);
            return reader.ReadToEnd();
        }

        static List<string> GetQuestion()
        {
            List<string> questions = new List<string> { "Сколько будет два плюс два умноженное на два?", "Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", "Укол делают каждые полчаса, сколько нужно минут для трех уколов?", "Пять свечей горело, две потухли. Сколько свечей осталось?" };
            return questions;
        }

        static List<string> RightAnswer()
        {
            List<string> answers = new List<string> { "6", "9", "25", "60", "2" };
            return answers;
        }

        static int GetRandom(int cntQ)
        {
            Random random = new Random();
            return random.Next(0, cntQ);
        }

        private static string CalculateDiagnos(int cntRightAnswer, int cntQuestion)
        {
            string[] diagnosis = new string[] { "Идиот", "Кретин", "Дурак", "Нормальный", "Талант", "Гений" };
            int indexDiagnos = cntRightAnswer
                * (diagnosis.Length - 1)
                / cntQuestion;
            return diagnosis[indexDiagnos];
        }
        static string AddName()
        {
            string name = "-";
            return name;
        }
    }
}