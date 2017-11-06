using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using BartercardTest.Sort;
using BartercardTest.Print;

namespace UnitTestBartercard
{
    [TestClass]
    public class UnitTestCustomSort
    {
        int[] arr01 = { 7, 7, 7, 7, 7, 7, 7, 9, 0, 3, 3, 1, 2, 2, 4, 4, 4, 4, 3, 5, 5, 5, 5, 5, 6, 11 };
        string expected01 = "0 1 6 9 11 2 2 3 3 3 4 4 4 4 5 5 5 5 5 7 7 7 7 7 7 7";

        int[] arr02 = { 0, 0, 9, 8, 7, -1, -1, 0, 1 };
        string expected02 = "1 7 8 9 -1 -1 0 0 0";

        //Create int[100000] Array to test performance
        ArrayMock ArrMock = new ArrayMock(100000);

        [TestMethod]
        public void Test_SortLinq1()
        {
            ISort sort = new SortLinq();
            IPrintConsole pc = new PrintConsole();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                pc.Print(sort.CustonSort(arr01));
                string Retorno = sw.ToString().Replace("\r\n", " ").Trim(); ;
                Assert.AreEqual<string>(expected01, Retorno);
            }
        }       

        [TestMethod]
        public void Test_SortLinq2()
        {
            ISort sort = new SortLinq();
            IPrintConsole pc = new PrintConsole();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                pc.Print(sort.CustonSort(arr02));
                string Retorno = sw.ToString().Replace("\r\n", " ").Trim(); ;
                Assert.AreEqual<string>(expected02, Retorno);
            }
        }

        [TestMethod]
        public void Test_Sortfor1()
        {
            ISort sort = new SortFor();
            IPrintConsole pc = new PrintConsole();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                pc.Print(sort.CustonSort(arr01));
                string Retorno = sw.ToString().Replace("\r\n", " ").Trim(); ;
                Assert.AreEqual<string>(expected01, Retorno);
            }
        }

        [TestMethod]
        public void Test_Sortfor2()
        {
            ISort sort = new SortFor();
            IPrintConsole pc = new PrintConsole();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                pc.Print(sort.CustonSort(arr02));
                string Retorno = sw.ToString().Replace("\r\n", " ").Trim(); ;
                Assert.AreEqual<string>(expected02, Retorno);
            }
        }



        //The tests below are to compare the time required to sort an array with 100,000 items
        
        [TestMethod]
        public void Test_Performance_CustomSortLinq()
        {
            ISort sortLinq = new SortLinq();
            sortLinq.CustonSort(ArrMock.MockArray);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Test_Performance_CustomSortFor()
        {
            ISort sortFor = new SortFor();
            sortFor.CustonSort(ArrMock.MockArray);
            Assert.AreEqual(1, 1);
        }

    }
}