using System;
using System.Collections.Generic;
using System.Text;

namespace mzaki.sample.services
{
    public  class WaysCounter
    {
        public int CountPermutations(int n)
        {
            switch (n)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return 2;
                default:
                    return CountPermutations(n - 1) + CountPermutations(n - 2);
            }
        }

        public int CountCombinations(List<string> list)
        {
            return list.Count;
        }

    }
}
