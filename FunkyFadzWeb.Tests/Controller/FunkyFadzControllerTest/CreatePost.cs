using FunkyFadz.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FunkyFadzWeb.Tests.Controller.FunkyFadzControllerTest
{
    [TestClass]
    public class CreatePost : FunkyFadzControllerTestBase
    {
        [TestMethod]
        public void ShouldReturnRedirectToRouteReslut()
        {

            var result = Controller.Create(new FunkyFadzCreateModel());

            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));

        }

        [TestMethod]
        public void ShouldCallCreateOnce()
        {
            var result = Controller.Create(new FunkyFadzCreateModel());

            Assert.AreEqual(1, Service.CreateFunkyFadzCallCount);
        }
    }
}
