using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AdvanceCSharp___02.modals
{
    class Quiz
    {
        public static void firstQuiz( user User)
        {
            QuizQuestion question1 = new QuizQuestion("What is the capital of Tasmania?", new List<string> { "Dodoma", "Hobart", "Launceston", "Wellington" }, "Hobart");
            QuizQuestion question2 = new QuizQuestion("What is the tallest building in the Republic of the Congo?", new List<string> { "Kinshasa Democratic Republic of the Congo Temple", "Palais de la Nation", "Kongo Trade Centre", "Nabemba Tower" }, "Nabemba Tower");
            QuizQuestion question3 = new QuizQuestion("Which of these is not one of Pluto's moons?", new List<string> { "Styx", "Hydra", "Nix", "Lugia" }, "Nix");
            QuizQuestion question4 = new QuizQuestion("What is the smallest lake in the world?", new List<string> { "Onega Lake", "Benxi Lake", "Kivu Lake", "Wakatipu Lake" }, "Benxi Lake");
            QuizQuestion question5 = new QuizQuestion("What country has the largest population of alpacas?", new List<string> { "Chad", "Peru", "Australia", "Niger" }, "Peru");
            int counter = 0;
            counter = QuizLogic(question1, counter);
            counter = QuizLogic(question2, counter);
            counter = QuizLogic(question3, counter);
            counter = QuizLogic(question4, counter);
            counter = QuizLogic(question5, counter);
            switch (counter)
            {
                case 1:
                case 2:
                    User.Grade = "Good";
                    break;
                case 3:
                case 4:
                    User.Grade = "Very Good";
                    break;
                case 5:
                    User.Grade = "Excellent";
                    break;
                default:
                    User.Grade = "Bad";
                    break;
            }
            User.loggedIn = true;
            Console.Clear();
            Console.WriteLine("Very good, very nice bye bye");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Grade: " + User.Grade);
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Next one please");
            Thread.Sleep(3000);
            Console.Clear();
        }
        public static int CheckAnswer(QuizQuestion question,int counter)
        {
            bool isString = int.TryParse(Console.ReadLine(), out int answer);
            while (!isString || answer<= 0 || answer > 4)
            {
                Console.WriteLine("You entered something wrong please enter number from 1 to 4");
                isString = int.TryParse(Console.ReadLine(), out answer);
            }
            if (answer.Equals(question.CorrectAnswer))
                return counter++;
            else
                return counter;
        }
        public static void PrintAnswers(QuizQuestion question)
        {
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Console.WriteLine(i+1 + question.Answers[i]);
            }
        }
        public static int QuizLogic(QuizQuestion question, int counter)
        {
            Console.WriteLine(question.Question);
            PrintAnswers(question);
            CheckAnswer(question, counter);
            return counter;
        }
    }
}
