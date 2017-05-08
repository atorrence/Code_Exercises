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
    public class LateArrivalTests
    {
        [TestMethod()]
        public void IsLateArrivalTestLessTime()
        {
            LateArrival l = new LateArrival();
            Assert.IsTrue(l.IsLateArrival(20, 10, 60));
        }
        [TestMethod()]
        public void IsLateArrivalTestExactTime()
        {
            LateArrival l = new LateArrival();
            Assert.IsTrue(l.IsLateArrival(20, 20, 60));
        }
        [TestMethod()]
        public void IsLateArrivalTestMoreTime()
        {
            LateArrival l = new LateArrival();
            Assert.IsFalse(l.IsLateArrival(40, 60, 50));
        }
    }
}