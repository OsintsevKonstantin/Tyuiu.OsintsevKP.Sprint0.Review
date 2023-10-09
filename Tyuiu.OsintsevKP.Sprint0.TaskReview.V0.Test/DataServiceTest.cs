using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.OsintsevKP.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(20, DataService.Calc(1, 2, 1));
        }
    }
}
