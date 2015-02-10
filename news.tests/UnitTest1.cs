using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using News.Controllers;
using System.Web.Mvc;

namespace news.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Description("Test concernant l'action Index de HomeController")]
        public void VerifIndex()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //[Description("Test concernant l'action la vue retournée de l'action Index de HomeController")]
        //public void VerifViewRetourneeIndex()
        //{
        //    HomeController controller = new HomeController();

        //    ViewResult result = controller.Index() as ViewResult;

        //    Assert.IsNotNull(result);
        //    //Assert.AreEqual(result.ViewName, "Index");
        //}
    }
}
