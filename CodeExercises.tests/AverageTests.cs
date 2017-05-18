using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises.Tests
{
    [TestClass()]
    public class AverageTests
    {
        [TestMethod()]
        public void FindAverageTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            double result = Average.FindAverage(array);
            Assert.AreEqual(200.0 / 13.0, result);
        }
    }
}