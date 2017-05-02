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
    public class SummationTests
    {
        [TestMethod()]
        public void summationTest()
        {
            
            int result = Summation.summation(7);
            Assert.AreEqual(28, result);

        }
    }
}