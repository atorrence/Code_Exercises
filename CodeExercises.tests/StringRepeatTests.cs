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
    public class StringRepeatTests
    {
        [TestMethod()]
        public void repeatStrTest()
        {
            //Arrange
            StringRepeat sr = new StringRepeat();
            //Act
            //string result = sr.repeatStr(6, "I");
            //Assert
            Assert.AreEqual("IIIIII", sr.repeatStr(6, "I"));
            Assert.AreEqual("HelloHelloHelloHelloHello", sr.repeatStr(5, "Hello"));
        }
    }
}