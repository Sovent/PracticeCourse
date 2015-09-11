using System;
using System.Text;

namespace Lesson1
{
    class Program
    {
        #region Menu Methods
        static void WriteMenuOption(string optionText, bool isChecked)
        {
            if (isChecked)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                optionText = "->" + optionText;
                Console.WriteLine(optionText);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(optionText);
            }
        }

        static void PrintMenu(string header, string[] options, int currentOption)
        {
            Console.Clear();
            Console.WriteLine(header);
            for (int i = 0; i < options.Length; i++)
            {
                WriteMenuOption(options[i], currentOption == i);
            }
        }

        static int CreateMenu(string header, string[] options)
        {
            var currentOption = 0;
            PrintMenu(header, options, currentOption);
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (currentOption < options.Length)
                        {
                            PrintMenu(header, options, ++currentOption);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentOption > 0)
                        {
                            PrintMenu(header, options, --currentOption);
                        }
                        break;
                    case ConsoleKey.Enter:
                        return currentOption;
                }
            }
        }
        #endregion
        #region Main Methods
        static string[] AddWorker(string[] attenders)
        {
            Console.Clear();
            Console.Write("Enter newcomer's name\n->");
            var newcomer = Console.ReadLine();
            var tempArray = new string[attenders.Length + 1];
            for (int i = 0; i < attenders.Length; i++)
            {
                tempArray[i] = attenders[i];
            }
            tempArray[tempArray.Length - 1] = newcomer;
            return tempArray;
        }

        static void ShowWorkers(string[] attenders)
        {
            Console.Clear();
            if (attenders.Length == 0)
            {
                Console.WriteLine("The list is empty");
            }

            for (int i = 0; i < attenders.Length; i++)
            {
                Console.WriteLine(i + " " + attenders[i]);
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadKey();
        }

        static string[] RemoveWorker(string[] attenders)
        {
            if (attenders.Length == 0)
            {
                Console.Clear();
                Console.WriteLine("No workers to delete");
            }

            var numberOfItemToRemove = CreateMenu("Select worker who has left:", attenders);
            var tempArray = new string[attenders.Length - 1];
            for (int i = 0; i < numberOfItemToRemove; i++)
            {
                tempArray[i] = attenders[i];
            }

            for (int i = numberOfItemToRemove; i < tempArray.Length; i++)
            {
                tempArray[i] = attenders[i + 1];
            }

            return tempArray;
        }

        static bool ConfirmExit()
        {
            return CreateMenu("Do you really want to exit and lose all data?", new[] {"Yes", "No"}) == 0;
        }
        #endregion
        
        static void Main()
        {
            var attenders = new string[0];
            while (true)
            {
                var chosenOption = CreateMenu("Welcome to Attendence, choose option", new[] {"New worker", "Show current workers", "Remove worker", "Exit"});
                switch (chosenOption)
                {
                    case 0:
                        attenders = AddWorker(attenders);
                        break;
                    case 1:
                        ShowWorkers(attenders);
                        break;
                    case 2:
                        attenders = RemoveWorker(attenders);
                        break;
                    case 3:
                        if (ConfirmExit())
                        {
                            return;
                        }

                        break;
                }
            }
        }

        
    }
}
