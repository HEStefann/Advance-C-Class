using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceCSharp___02.modals
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
        public QuizQuestion(string question, List<string> answers,string correctAnswer)
        {
            Question = question;
            Answers = answers;
            CorrectAnswer = correctAnswer;
        }
    }
}
