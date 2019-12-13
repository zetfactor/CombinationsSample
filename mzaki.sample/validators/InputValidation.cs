using System;
using System.Collections.Generic;
using System.Text;

namespace mzaki.sample.validators
{
   public  class InputValidation
    {
        public  bool ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("You did not specify the balls count.");
                return false;
            }
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("The inserted value is not a number.");
                return false;
            }
            if (result <= 0)
            {
                Console.WriteLine("Your bag is already empty!");
                return false;
            }

            return true;
        }
    }
}
