using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PermutatiomAndCombination.Services
{
    public class PermutationsGenerator
    {
        private static List<string> _listAllPermutations = new List<string>();
        public void Swap(ref char aChar, ref char bChar)
        {
            if (aChar == bChar) return;

            var valueHolder = aChar;
            aChar = bChar;
            bChar = valueHolder;
        }

        public List<string> GeneratePermutation(char[] list)
        {
            _listAllPermutations.Clear();
            int x = list.Length - 1;
            GeneratePermutation(list, 0, x);
            _listAllPermutations.Add(new string(list));
            return _listAllPermutations.Distinct().ToList();
        }

        public List<string> GeneratePermutation(char[] list, int y, int z)
        {
            if (y == z)
            {
                if (!_listAllPermutations.Any(x => _listAllPermutations.Contains(new string(list))))
                {
                    _listAllPermutations.Add(new string(list));
                }
            }
            else
            {
                for (int i = y; i <= z; i++)
                {
                    Swap(ref list[y], ref list[i]);
                    GeneratePermutation(list, y + 1, z);
                    Swap(ref list[y], ref list[i]);
                }
            }
            return _listAllPermutations.Distinct().ToList();
        }

    }
}
