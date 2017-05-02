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
        public void GetDriversLicenseTestUnder16()
        {
            DriversLicense dL = new DriversLicense();
            bool answer = dL.GetDriversLicense(15, 20, false, true);
            Assert.IsFalse(answer);
        }
        public void GetDriversLicenseTest16ButNotEnoughHours()
        {
            DriversLicense dL = new DriversLicense();
            bool answer = dL.GetDriversLicense(16, 20, false, true);
            Assert.IsFalse(answer);
        }
        public void GetDriversLicenseTestBetween16and18()
        {

            DriversLicense dL = new DriversLicense();
            bool answer = dL.GetDriversLicense(16, 50, true, true);
            Assert.IsTrue(answer);
        }
        public void GetDriversLicenseTest1Over18()
        {
            DriversLicense dL = new DriversLicense();
            bool answer = dL.GetDriversLicense(18, 0, true, true);
            Assert.IsTrue(answer);
        }
    }
}