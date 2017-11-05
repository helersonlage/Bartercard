using BartercardTest.Sort;
using System;
using System.Collections.Generic;
using System.Text;

namespace BartercardTest.Print
{
    public class PrintConsole : IPrintConsole
    {
        public void Print(List<frequency> printlst)
        {
            // Print Console
            for (int i = 0; i < printlst.Count; i++)
            {
                for (int j = 0; j < printlst[i].freq; j++)
                {
                    Console.WriteLine(printlst[i].num.ToString());
                }
            }
        }
    }
}
