using mzaki.sample.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace mzaki.sample.AppManager
{
    public class BaseClass
    {
        public bool TryAgain(string decision)
        {
            if (decision?.ToUpper() == "Y")
            {
                return false;
            }
            return true;
        }

        public string ResultSelector()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Select your output choice first:");
            Console.WriteLine("1 - for Combinations");
            Console.WriteLine("2 - for Permutations");
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    userChoice = "Combinations";
                    break;
                case "2":
                    userChoice = "Permutations";
                    break;
                default:
                    Console.WriteLine("Ivalid Choice Permutation will be selected by default.");
                    userChoice = "Permutations";
                    break;
            }

            Console.WriteLine("-----------------------------------------------");
            return userChoice;
        }

        public void PrintResult(int bagesize, List<string> listToPrint, string userChoice)
        {
            var waysPrinter = new WaysService();
            var waysCounter = new WaysCounter();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("There are {0} {1} ways to empty a bag of {2} balls.",
                userChoice == "Combination" ? waysCounter.CountCombinations(listToPrint) : waysCounter.CountPermutations(bagesize), userChoice, bagesize);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Different  {0}  ways you can remove the balls :", userChoice);
            listToPrint = waysPrinter.GetWays(bagesize, userChoice == "Combinations" ? false : true);
            foreach (var item in listToPrint)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Do you want to Exit ? Y/N");

        }

        public string BagSize()
        {
            Console.WriteLine("How many balls in the bag ?");
            return Console.ReadLine();
        }

    }
}
