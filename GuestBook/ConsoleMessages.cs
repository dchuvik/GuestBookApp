using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    internal class ConsoleMessages
    {
        public static (string name, int partyAmount) GetUserInfo()
        {
            bool isInt;
            string name;
            int partyAmount;

            Console.Write("Please enter a name for your party: ");
            name = Console.ReadLine();
            Console.Write("Please enter the number in of people in your party: ");

            isInt = int.TryParse(Console.ReadLine(), out partyAmount);

            while (!isInt)
            {
                Console.Write("invalid input, try again:  ");
                name = Console.ReadLine();
                isInt = int.TryParse(name, out partyAmount);
            }


            return (name, partyAmount); 

        }

        public static (List<string> partyNames, List<int> partyGuestAmount) LoopGetUserInfo()
        {
            string continueAnswer = string.Empty;                
            List<string> partyNames = new List<string>();
            List<int> partyGuestAmount = new List<int>();

            do
            {

                (string name, int partyAmount) Party = ConsoleMessages.GetUserInfo();
                partyNames.Add(Party.name);
                partyGuestAmount.Add(Party.partyAmount);

                Console.WriteLine("Enter another family? (yes/no)");
                continueAnswer = Console.ReadLine().ToLower();

                do
                {
                    Console.Write("invalid input, try again... ");
                    continueAnswer = Console.ReadLine().ToLower();
                }
                while (continueAnswer != "yes" && continueAnswer != "no");

            } while (continueAnswer == "yes");
            return (partyNames, partyGuestAmount);
        }
        public static void PrintInfo(List<string> partyNames, List<int> partyGuestAmount)
        {
            Console.WriteLine("The guest's include...");
            foreach (string partyName in partyNames)
            {
                Console.WriteLine($"{partyName}'s Party");
            }


            Console.WriteLine($"Total amount of guests: {partyGuestAmount.Sum()}");

        }

    }
}
