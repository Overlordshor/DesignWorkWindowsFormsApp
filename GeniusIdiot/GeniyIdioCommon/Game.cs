using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiotCommon
{
    public class Game
    {
        public string PathToResultDiagnose = "result_diagnose.json";
        private User user;
        private List<Question> questions;
        private Question currentQuestion;
        private int numberQuestion;
        private List<UserResult> usersResult;

        public Game(User user)
        {
            this.user = user;
            questions = Init();
        }

        private List<Question> Init()
        {
            if (FileProvider.Exist(Question.FilePath))
            {
                questions = Question.GetQuestionsFromFile();
            }
            else
            {
                questions = Question.GetQuestions();
                QuestionsSaveToFile(questions);
            }
                return questions;
            
        }

        public void QuestionsSaveToFile(List<Question> questions)
        {
            var serializedQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.ReSave(Question.FilePath, serializedQuestions);
        }

        public void AddNewQuestion(string text, string answer)
        {   
            var newQuestion = new Question(text, answer);
            var questions = Question.GetQuestionsFromFile();
            questions.Add(newQuestion);
            QuestionsSaveToFile(questions);
        }

        public bool Over()
        {
            return GetQuestionCount() == 0;
        }
        public Question PopRandomQuestion()
        {
            Random random = new Random();
            int currentIndex = random.Next(GetQuestionCount());
            currentQuestion = questions[currentIndex];
            questions.Remove(currentQuestion);
            return currentQuestion;
        }
         
        public string PrintNumberQuestion()
        {
            numberQuestion++;
            return "Вопрос №" + numberQuestion + ": ";
        }
        public void AddUserAnswer(string userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AddRightAnswer();
            }
        }
        public string PrintDiagnose(User user)
        {
            List<Diagnose> diagnoses = Diagnose.GetDiagnoses();
            var indexUserDiagnos = Diagnose.CalculateValueDiagnose(user.CountRightAnswer, diagnoses.Count, numberQuestion);
            user.SetDiagnose(diagnoses[indexUserDiagnos]);
            return user.Name + ", Ваш диагноз - " + user.Diagnose.Name;
        }
        public void AddUserResult()
        {
            var isExist = FileProvider.Exist(PathToResultDiagnose);
            if (!isExist)
            {
                usersResult = new List<UserResult>();
            }
            else
            {
                usersResult = LoadUserResult();
            }
            usersResult.Add(new UserResult(user.Name, user.CountRightAnswer, user.Diagnose.Name));
            var serializedResults = JsonConvert.SerializeObject(usersResult, Formatting.Indented);
            FileProvider.ReSave(PathToResultDiagnose, serializedResults);
        }
        public List<UserResult> LoadUserResult()
        {
            var serializedResult = FileProvider.Load(PathToResultDiagnose);
            var deserilizedData = JsonConvert.DeserializeObject<List<UserResult>>(serializedResult);
            return deserilizedData;
        }
        private int GetQuestionCount()
        {
            return questions.Count;
        }

    }
}
