using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CI_UNIT_LAB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumar()
        {
            int a = 10;
            int b = 10;
            int result = 10;
            CI_TEST.Controllers.HomeController controller = new CI_TEST.Controllers.HomeController();
            Assert.AreEqual(result, controller.sumar(a, b));
        }
    }
}
