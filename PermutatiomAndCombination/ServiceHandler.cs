using PermutatiomAndCombination.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermutatiomAndCombination
{
    public class ServiceHandler
    {
        private CombinationsGenerator service = new CombinationsGenerator();
        public List<string> GenerateList(int bageSize, bool includePermutations)
        {
            return service.GetCombinations(bageSize, includePermutations);
        }
    }
}
