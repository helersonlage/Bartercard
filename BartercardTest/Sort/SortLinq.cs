using System;
using System.Collections.Generic;
using System.Linq;


namespace BartercardTest.Sort
{
    public class SortLinq : SortBase, ISort
    {
        /// <summary>
        /// Custon Sort using Linq
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public override List<frequency> CustonSort(int[] array)
        {
            var print = array.GroupBy(c => c).Select(a => new frequency(a.Key, a.Count()))
                 .OrderBy(a => a.freq).ThenBy(b => b.num).ToList();
            return print;
        }
    }
}

   
