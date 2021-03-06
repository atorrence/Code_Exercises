﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeExercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExercises.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void GetFizzBuzzTest()
        {
            //Arrange
            FizzBuzz fb = new FizzBuzz();
            //Act
            string result = fb.GetFizzBuzz(3);
            //Assert
            Assert.AreEqual("Fizz", result);
        }
    }
}