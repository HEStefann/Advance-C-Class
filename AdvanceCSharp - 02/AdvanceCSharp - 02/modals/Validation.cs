using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AdvanceCSharp___02.modals
{
    class Validation
    {
        public static user UsernameVal(string username, List<user> users)
        {
            int checkUsername = users.Select(x => x.Username == username).ToList().IndexOf(true);
            while (checkUsername == -1)
            {
                Console.WriteLine("Username is incorect please try again :D");
                Console.WriteLine("Enter username: ");
                username = Console.ReadLine();
                checkUsername = users.Select(x => x.Username == username).ToList().IndexOf(true);
            }
            return users[checkUsername];

        }
        public static bool PasswordVal(string password, user user)
        {
            int counter = 1;
            while(user.Password != password)
            {
                Console.WriteLine("You enter a wrong password please try again :D");
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
                if (counter == 2 )
                {
                    if (user.Password != password)
                    {
                        Console.WriteLine("You have entered a wrong password too many times!");
                        Console.WriteLine("Try again in 30 minutes!");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                    }
                    else
                        return true;
                }
                counter++;
            }
            return true;
        }
    }
}
