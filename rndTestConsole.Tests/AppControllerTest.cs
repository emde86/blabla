using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using rndTestConsole.Controllers;

namespace rndTestConsole.Tests
{
    [TestFixture]
    public class AppControllerTest
    {
        [Test]
        public void AppControllerTest_init_OK()
        {
            AppController appController = new AppController(2, 3);

            Assert.AreEqual(4, appController.A, "Something is wrong with A");
            Assert.AreEqual(15, appController.B, "Something is wrong with B");
        }

        [Test]
        public void AppControllerTest_init_ERROR()
        {
            AppController appController = new AppController(5, 2);

            Assert.AreEqual(10, appController.A, "Something is wrong with A");
            Assert.AreEqual(10, appController.B, "Something is wrong with B");
        }
    }
}
