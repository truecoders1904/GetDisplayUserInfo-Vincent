using System;
using System.Collections.Generic;
using System.Text;

namespace Project_2
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteAnimal { get; set; }
        public int FavoriteNumber { get; set; }
        public string AnswerQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();            
        }
        public int AnswerQuestionWithInteger(string question)
        {
            string stringAnswer = AnswerQuestion(question);
            return int.Parse(stringAnswer);
        }
    }
}
