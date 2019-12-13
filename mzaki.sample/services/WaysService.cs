using System;
using System.Collections.Generic;
using System.Linq;
using PermutatiomAndCombination;


namespace mzaki.sample.services
{
    public class WaysService
    {
        private static List<string> _listAllcombinationsAndPremutations = new List<string>();
        private ServiceHandler service = new ServiceHandler();
        public List<string> GetWays(int bagsize, bool includePermutations)
        {
            _listAllcombinationsAndPremutations.Clear();
            _listAllcombinationsAndPremutations = service.GenerateList(bagsize, includePermutations);
            return ListFormatter(_listAllcombinationsAndPremutations);
        }
        private List<string> ListFormatter(List<string> list)
        {
            var formattedList = new List<string>();
            foreach (var item in _listAllcombinationsAndPremutations.Distinct())
            {
                var formattedItem = "";
                var comboArr = item.ToCharArray();
                for (int i = 0; i < comboArr.Length; i++)
                {
                    if (i != 0)
                    {
                        formattedItem += "-" + comboArr[i];
                    }
                    else
                    {
                        formattedItem += comboArr[i];
                    }
                }
                formattedList.Add(formattedItem);
            }
            return formattedList;
        }
    }
}
