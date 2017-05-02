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
    public class ExesAndOhsTests
    {
        [TestMethod()]
        public void DoesXEqualOTest()
        {
            //Arrange
            ExesAndOhs xo = new ExesAndOhs();
            //Act
            //bool result = xo.DoesXEqualO("ooxx");
            //Assert
            Assert.IsTrue(xo.DoesXEqualO("ooxx"));
            Assert.IsTrue(xo.DoesXEqualO("ooxXm"));
            Assert.IsFalse(xo.DoesXEqualO("xooxx"));
            Assert.IsTrue(xo.DoesXEqualO("zpzpzpp"));
            Assert.IsFalse(xo.DoesXEqualO("zzoo"));
             
        }
      
    }
}