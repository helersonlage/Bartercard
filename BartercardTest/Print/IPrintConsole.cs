using System.Collections.Generic;
using BartercardTest.Sort;

namespace BartercardTest.Print
{
    public interface IPrintConsole
    {
        void Print(List<frequency> printlst);
    }
}