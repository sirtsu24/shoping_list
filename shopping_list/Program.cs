using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<string>();
            var currentDate = DateTime.Now;
            string userInput;
            string userAnswer;
            string userChoice;



            Console.WriteLine("Add idems in shoppinglist: ");
            userInput = Console.ReadLine();
            string[] list = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {list[i]}");
            }

            foreach (string element in list)
            {
                userList.Add(element);
            }

        Start:

            Console.WriteLine("Do you want add or remove item? If not - enter no");
            userAnswer = Console.ReadLine();



            if (userAnswer.ToLower() == "add")
            {
                Console.WriteLine("What do you want to add?");
                userChoice = Console.ReadLine();
                userList.Add(userChoice);

                int i = 1;
                foreach (string element in userList)
                {

                    Console.WriteLine($"item {i} {element}");
                    i++;

                }
                Console.WriteLine($"refreshed {currentDate}");
                goto Start;


            }
            else if (userAnswer.ToLower() == "remove")
            {
                string userItem;
                Console.WriteLine("What you want to remove?");
                userItem = Console.ReadLine();
                userList.Remove(userItem);

                int i = 1;
                foreach (string element in userList)
                {
                    Console.WriteLine($"item {i} {element}");
                    i++;

                }
                Console.WriteLine($"refreshed {currentDate}");

                goto Start;

            }
            else if (userAnswer.ToLower() == "no")
            {
                Console.WriteLine("Thank for shopping! Goodbye!");

            }
            else
            {
                Console.WriteLine("Choose correct answer (add, remove or no)");
                goto Start;
            }

        }
    }
}