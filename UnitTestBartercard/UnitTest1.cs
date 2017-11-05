using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using BartercardTest.Sort;

namespace UnitTestBartercard
{
    [TestClass]
    public class UnitTest1
    {
        int[] arr01 = { 7, 7, 7, 7, 7, 7, 7, 9, 0, 3, 3, 1, 2, 2, 4, 4, 4, 4, 3, 5, 5, 5, 5, 5, 6, 11 };       
        string expected01 = "0 1 6 9 11 2 2 3 3 3 4 4 4 4 5 5 5 5 5 7 7 7 7 7 7 7";

        [TestMethod]
        public void Test_SortLinq()
        {
            ISort sort = new SortLinq();
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                sort.Print(sort.CustonSort(arr01));
                string Retorno = sw.ToString().Replace("\r\n", " ").Trim(); ;
                Assert.AreEqual<string>(expected01, Retorno);
            }
        }
    }
}
