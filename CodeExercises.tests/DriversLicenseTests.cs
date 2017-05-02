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
    public class DriversLicenseTests
    {
        [TestMethod()]
        public void GetDriversLicenseTestFalse()
        {
            //Arrange
            DriversLicense dL = new DriversLicense();
            //Act
            bool answer = dL.GetDriversLicense(16, 20, false, true);
            bool answer2 = dL.GetDriversLicense(16, 50, false, false);
            //Assert
            Assert.IsFalse(answer);
            Assert.IsFalse(answer2);
        }
             public void GetDriversLicenseTestTrue()
        {
            //Arrange
            DriversLicense dL = new DriversLicense();
            //Act
            bool answer3 = dL.GetDriversLicense(16, 50, true, true);
            bool answer4 = dL.GetDriversLicense(18, 0, true, true);
            //Assert
            Assert.IsTrue(answer3);
            Assert.IsTrue(answer4);
        }
    }
}