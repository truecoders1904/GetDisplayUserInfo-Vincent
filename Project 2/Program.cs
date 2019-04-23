using System;
using System.Collections.Generic;
using System.Text;


namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.FirstName = user.AnswerQuestion("Hello! What is your first name?");
            user.LastName = user.AnswerQuestion($"Hey {user.FirstName}, can you please give me your last name as well.");
            user.FavoriteNumber = user.AnswerQuestionWithInteger($"Okay {user.FirstName} {user.LastName} could you also give me your favorite number, please.");
            user.FavoriteAnimal = user.AnswerQuestion($"Sorry about all of that {user.FirstName} all I need now is whats your favorite animal please.");

            if (user.FavoriteNumber > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hey {user.FirstName} {user.LastName}, the number {user.FavoriteNumber} is a pretty lucky number ;) \nand so is a {user.FavoriteAnimal} . \nToo bad today wasn't your lucky day you just gave ne all your answers to your security questions :))");
            }
            else if (user.FavoriteNumber < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hello {user.FirstName} {user.LastName}, I am sorry to inform you that a {user.FavoriteNumber} is lame number and so is a {user.FavoriteAnimal} :P. \nokay goodbye XD");
            }
            else
            {
                Console.WriteLine($"Hello {user.FirstName} {user.LastName},the number {user.FavoriteNumber} is actually a cool number and {user.FavoriteAnimal}(s) are pretty cool animals too. \nThank you for being wise human being 8)");

            }

        }
    }
}
