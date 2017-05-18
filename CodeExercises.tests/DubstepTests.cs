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
    public class DubstepTests
    {
        [TestMethod()]
        public void SongDecoderTest()
        {
            Dubstep d = new Dubstep();
            Assert.AreEqual("WE ARE THE CHAMPIONS MY FRIEND", d.SongDecoder("WUBWEWUBAREWUBWUBTHEWUBCHAMPIONSWUBMYWUBFRIENDWUB"));
        }

        [TestMethod()]
        public void SongDecoderShortTest()
        {
            Dubstep d = new Dubstep();
            Assert.AreEqual("ABC", d.SongDecoder("WUBWUBABC"));
        }
    }
}