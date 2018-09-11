using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        public string gameName;
        Dictionary<int, Contestant> sweeps = new Dictionary<int, Contestant>();
        public int winningNumber;
        public bool searchReset;
        
        public Sweepstakes(string GameName)
        {
            gameName = GameName;
        }

        public void runMenu()
        {
            Console.WriteLine("Press 1 to enter contestants, press 2 begin raffle, press 3 to check contestant information.");
            string choice = Console.ReadLine().ToLower();
            if (choice == "1")
            {
                createContestants();
            }

            else if (choice == "2")


            {

                PickWinner();

            }

            else if (choice == "3")

            {
                contestantMenu();
            }

            else

            {
                Console.WriteLine("That is not a valid option in this menu.");
                runMenu();
            }

        }

        public void createContestants()
        {
            Console.WriteLine("Enter contestant's first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter contestant's last name.");
            string lastName = Console.ReadLine();
            int ticketNumber = sweeps.Count;
            string result = "pending";

            Contestant newContestant = new Contestant(firstName, lastName, ticketNumber, result);
            Console.WriteLine("Your ticket number is " + ticketNumber);
            RegisterContestant(newContestant);
            runMenu();
        }


        public void RegisterContestant(Contestant contestant)
        {

            sweeps.Add(contestant.ticketNumber, contestant);
        }

        public int pickWinningNumber()
        {

            Random random = new Random();
            winningNumber = random.Next(0, sweeps.Count);
            Console.WriteLine("The winning number is " + winningNumber);
            return winningNumber;
        }

        public string PickWinner()
        {
            pickWinningNumber();
            Contestant winner = null;
            for (int i = 0; i < sweeps.Count; i++)
            {

                if (sweeps[i].ticketNumber == winningNumber)
                {
                    winner = sweeps[i];
                    sweeps[i].result = ("Winner!");
                }

                else
                {
                    sweeps[i].result = ("Loser");
                }

            }
            Console.WriteLine("The winner is " + winner.firstName + " " + winner.lastName);
            runMenu();

            return winner.firstName + winner.lastName;
        }

        public void contestantMenu()
        {
            searchReset = false;
            Console.WriteLine("Enter first name or contestant you want to search");
            string firstNameChoice = Console.ReadLine().ToLower();
            Console.WriteLine("Enter last name or contestant you want to search");
            string lastNameChoice = Console.ReadLine().ToLower();

            for (int i = 0; i < sweeps.Count; i++)
            {

                if (sweeps[i].firstName == firstNameChoice && sweeps[i].lastName == lastNameChoice)
                {
                    Console.WriteLine("Contestant's name is " + sweeps[i].firstName + " " + sweeps[i].lastName);
                    Console.WriteLine("Contestant's ticket number is " + sweeps[i].ticketNumber);
                    Console.WriteLine("Result: " + sweeps[i].result);
                    searchReset = true;
                    runMenu();
                }

            }

            if (searchReset == false)
            {
                Console.WriteLine("Error: There is no such name in the system.");
                searchReset = true;
                runMenu();
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {

            Console.WriteLine("Contestent Name : {0}", contestant.firstName + "" + contestant.lastName);
            Console.WriteLine("Contestent ticket number : {0}", contestant.ticketNumber);
            Console.WriteLine("You {0}", contestant.result);

        }
    }
}
