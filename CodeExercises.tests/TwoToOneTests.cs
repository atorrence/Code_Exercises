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
    public class TwoToOneTests
    {
        [TestMethod()]
        public void LongestTest()
        {
            string s1 = "xyaabbbccccdefww";
            string s2 = "xxxxyyyyabklmopq";
            TwoToOne.Longest(s1, s2);
            Assert.AreEqual("abcdefklmopqwxy", TwoToOne.Longest(s1, s2));
            
        }
    }
}