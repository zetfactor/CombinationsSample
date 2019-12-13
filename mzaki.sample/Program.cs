using mzaki.sample.AppManager;
using mzaki.sample.services;
using mzaki.sample.validators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mzaki.sample
{
    class Program
    {
        private static bool proceed = true;
        private static string bagesize = string.Empty;
        private static string userChoice = "";
        private static List<string>  listToPrint = new List<string>();
        private static InputValidation validator = new InputValidation();
        private static BaseClass appManager = new BaseClass();

        static public void Main()
        {
            while (proceed)
            {
                  userChoice = appManager.ResultSelector();
                  bagesize = appManager.BagSize();
                if (validator.ValidateInput(bagesize))
                {
                    var _bageSize = int.Parse(bagesize);
                    appManager.PrintResult(_bageSize, listToPrint, userChoice);
                    Reset();
                    proceed = appManager.TryAgain(Console.ReadLine());
                }
            }
        }
        private static void Reset()
        {
            listToPrint.Clear();
            bagesize = "";
            userChoice = "";
        }
 
    }
}



