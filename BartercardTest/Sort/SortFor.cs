using System;
using System.Collections.Generic;
using System.Linq;

namespace BartercardTest.Sort
{
    public class SortFor : SortBase, ISort
    {
        /// <summary>
        ///  Sort Array
        /// </summary>
        /// <param name="array"> Int[]</param>
        public override List<frequency> CustonSort(int[] array)
        {
            List<frequency> lst = new List<frequency>();
            frequency frq;

            var sorted = array.OrderBy(a => a).ToArray();
            for (int i = 0; i < sorted.Length; i++)
            {
                if (!(i > 0) || (sorted[i] != sorted[i - 1]))
                {

                    frq = new frequency(sorted[i], sorted.Count(a => a.Equals(sorted[i])));
                    lst.Add(frq);


                }
            }

            //Sort
            var print = lst.OrderBy(a => a.freq).ThenBy(b => b.num).ToList();

            return print;


        }
    }
}
