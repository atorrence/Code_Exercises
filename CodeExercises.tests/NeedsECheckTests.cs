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
    public class NeedsECheckTests
    {
        [TestMethod()]
        public void NeedsECheckTestOddYear()
        {
            NeedsECheck n = new NeedsECheck();
            Assert.IsTrue(n.DoesNeedECheck(2017, 2011));
        }

        [TestMethod()]
        public void NeedsECheckTestEvenYear()
        {
            NeedsECheck n = new NeedsECheck();
            Assert.IsTrue(n.DoesNeedECheck(2016, 2004));
        }

        [TestMethod()]
        public void NeedsECheckTestLessThanFourYearsOld()
        {
            NeedsECheck n = new NeedsECheck();
            Assert.IsFalse(n.DoesNeedECheck(2012, 2011));
        }
        [TestMethod()]
        public void NeedsECheckTest0ver25YearsOld()
        {
            NeedsECheck n = new NeedsECheck();
            Assert.IsFalse(n.DoesNeedECheck(2011, 1992));
        }
    }
}