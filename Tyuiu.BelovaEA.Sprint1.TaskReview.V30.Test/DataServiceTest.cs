using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint1.TaskReview.V30.Lib;

namespace Tyuiu.BelovaEA.Sprint1.TaskReview.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 5.0;
            Assert.AreEqual(2, ds.Calculate(x,y));
        }
    }
}
