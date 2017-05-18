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
    public class SecondHighestExerciseTests
    {
        [TestMethod()]
        public void SecondHighestTestOnlyTwo()
        {
            SecondHighestExercise s = new SecondHighestExercise();
            int[] nums = new int[3] { 1, 3, 3 };
            Assert.AreEqual(3, s.SecondHighest(nums));
        }
        [TestMethod()]
        public void SecondHighestTestEmptyArray()
        {
            SecondHighestExercise s = new SecondHighestExercise();
            int[] nums = new int[0];
            Assert.AreEqual(0, s.SecondHighest(nums));
        }
        [TestMethod()]
        public void SecondHighestTestArrayLength1()
        {
            SecondHighestExercise s = new SecondHighestExercise();
            int[] nums = new int[1] { 1 };
            Assert.AreEqual(1, s.SecondHighest(nums));
        }
        [TestMethod()]
        public void SecondHighestTestArray()
        {
            SecondHighestExercise s = new SecondHighestExercise();
            int[] nums = new int[3] { 1, 3, 5 };
            Assert.AreEqual(3, s.SecondHighest(nums));
        }
        [TestMethod()]
        public void SecondHighestTestLongerArray()
        {
            SecondHighestExercise s = new SecondHighestExercise();
            int[] nums = new int[6] {1, 4, 6, 8, 23, 13 };
            Assert.AreEqual(13, s.SecondHighest(nums));
        }
    }
}