using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1
{
    [TestClass]
    public class BasicMaths
    {
        [TestMethod]
        public void TestMethod1()
        {
            2.  public class UnitTest1
        {  
    [TestMethod]  
            public void Test_AddMethod()
            {
                5.BasicMaths bm = new BasicMaths();
                6.              double res = bm.Add(10, 10);
                7.Assert.AreEqual(res, 20);
                8.          }  
        [TestMethod]  
	    public void Test_SubstractMethod()
            {
                BasicMaths bm = new BasicMaths();
                             double res = bm.Substract(10, 10);
                Assert.AreEqual(res, 0);
                         }  
	        [TestMethod]  
	    public void Test_DivideMethod()
            {
                BasicMaths bm = new BasicMaths();
                             double res = bm.divide(10, 5);
                Assert.AreEqual(res, 2);
                         }  
	        [TestMethod]  
	    public void Test_MultiplyMethod()
            {
                BasicMaths bm = new BasicMaths();
                         double res = bm.Multiply(10, 10);
                Assert.AreEqual(res, 100);
                     }

        }
    }
}
