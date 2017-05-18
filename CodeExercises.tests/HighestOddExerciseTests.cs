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
    public class HighestOddExerciseTests
    {
        [TestMethod()]
        public void HighestOddTest()
        {
            HighestOddExercise h = new HighestOddExercise();
            int[] nums = new int[3] { 3, 7, 8 };
            Assert.AreEqual(7,h.HighestOdd(nums));
        }
        [TestMethod()]
        public void HighestOddTestEmptyString()
        {
            HighestOddExercise h = new HighestOddExercise();
            int[] nums = new int[0];
            Assert.AreEqual(0, h.HighestOdd(nums));
        }
        [TestMethod()]
        public void HighestOddTestNoOdd()
        {
            HighestOddExercise h = new HighestOddExercise();
            int[] nums = new int[2] { 2, 10 };
            Assert.AreEqual(0, h.HighestOdd(nums));
        }
    }
}