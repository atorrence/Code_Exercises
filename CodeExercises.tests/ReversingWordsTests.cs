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
    public class ReversingWordsTests
    {
        [TestMethod()]
        public void reverseWordsTest()
        {
            //Arrange
            ReversingWords r = new ReversingWords();
            //Act
            //string result = r.reverseWords("Hello World");
            //Assert
            Assert.AreEqual("World Hello", r.reverseWords("Hello World"));
            Assert.AreEqual("test another is This", r.reverseWords("This is another test"));
        }
    }
}