using System;
using System.Collections.Generic;
using System.Text;

namespace PermutatiomAndCombination.Services
{
    public class CombinationsGenerator
    {
        private static List<string> _listAllCombinations = new List<string>();
        private static PermutationsGenerator permutations = new PermutationsGenerator();
        public List<string> GetCombinations(int n, bool includePermutations)
        {
            _listAllCombinations.Clear();
            int[] arr = new int[n];
            GenerateCombination(arr, 0, n, n, includePermutations);
            return _listAllCombinations;
        }
        private void GenerateCombination(int[] arr, int index, int num, int reducedNum, bool includePermutations)
        {
            if (reducedNum < 0)
                return;

            if (reducedNum == 0)
            {
                var arrString = "";
                for (int i = 0; i < index; i++)
                {
                    arrString += arr[i];
                }
                if (includePermutations)
                {
                    _listAllCombinations.AddRange(permutations.GeneratePermutation(arrString.ToCharArray()));
                }
                else
                {
                    _listAllCombinations.Add(arrString);
                }
                return;
            }
            int prev = (index == 0) ? 1 : arr[index - 1];
            for (int k = prev; k <= 2; k++)
            {
                arr[index] = k;
                GenerateCombination(arr, index + 1, num, reducedNum - k, includePermutations);
            }
        }

    }
}
