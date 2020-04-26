using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiotCommon
{
    public class Question
    {
        public const string FilePath = "questions.json";
        public string Text;
        public string Answer;
        public static int Number;
        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;
        }
        public static List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>()
            {
               new Question("Сколько будет два плюс два умноженные на два?", "6"),
               new Question("Бревно нужно распилить на десять частей, сколько надо сделать распилов?", "9"),
               new Question("На 2 руках 10 пальцев. Сколько пальцев на 5 руках?", "25"),
               new Question("Укол делают каждые пол часа, сколько нужно минут для трех уколов?", "60"),
               new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", "2"),
            };
            return questions;
        }
        public static List<Question> GetQuestionsFromFile()
        {
            var data = FileProvider.Load(FilePath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(data);
            return questions;

        }
        public string PrintQuestion()
        {
            return Text;
        }
        public string PrintRightAnswer()
        {
            return Answer;
        }
        public int PrintNumberQuestion()
        {
            return ++Number;
        }
        public static int GetRandom(int cntQ)
        {
                Random random = new Random();
                return random.Next(0, cntQ);
        }
    }
}