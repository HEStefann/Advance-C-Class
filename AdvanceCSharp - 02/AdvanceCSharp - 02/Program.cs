using AdvanceCSharp___02.modals;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AdvanceCSharp___02
{
    class Program
    {
        static void Main(string[] args)
        {
            user student1 = new user("student1", "123", Role.Student);
            user student2 = new user("student2", "123", Role.Student);
            user student3 = new user("student3", "123", Role.Student);
            user student4 = new user("student4", "123", Role.Student);
            user teacher1 = new user("teacher1", "123", Role.Teacher);
            user teacher2 = new user("teacher2", "123", Role.Teacher);
            user teacher3 = new user("teacher3", "123", Role.Teacher);
            List<user> users = new List<user> {student1,student2,student3,student4,teacher1,teacher2,teacher3};
            while (true)
            {
                Console.WriteLine("Enter username: ");
                string username = Console.ReadLine();
                var logedUser = Validation.UsernameVal(username, users);
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();
                Validation.PasswordVal(password, logedUser);
                if (logedUser.Role.Equals(Role.Teacher))
                {
                    Console.Clear();
                    foreach (user student in users)
                    {
                        if (student.Role.Equals(Role.Student))
                        {
                            if (student.loggedIn.Equals(true))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(student.Username +" "+ student.Grade);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine(student.Username ,student.loggedIn);
                            }
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    if (logedUser.loggedIn)
                    {
                        Console.WriteLine("YOU HAVE BEEN LOGED IN ALREADY GO AWAY!!!");
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                    else
                    {
                        Quiz.firstQuiz(logedUser);
                    }
                }
            }
        }
    }
}
