using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatRacingProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatRacingProject.Tests
{
    [TestClass()]
    public class PlaygroundTests
    {
        [TestMethod()]
        public void PlaygroundTest()
        {
            Operation op = new Operation();
            if (op.move() < 50)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }

        [TestMethod()]
        public void PlaygroundTest2()
        {
            Operation op = new Operation();
            if (op.stop()==950)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }


    }
}