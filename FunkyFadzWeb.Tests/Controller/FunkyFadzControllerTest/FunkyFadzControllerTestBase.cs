using FunkyFadz.Contracts;
using FunkyFadz.WebMVC.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadzWeb.Tests.Controller.FunkyFadzControllerTest
{
    [TestClass]
    public abstract class FunkyFadzControllerTestBase
    {
        protected FunkyFadzController Controller;

        protected FakeFunkyFadzService Service;

        //Arrange
        //Act
        //Assert

        [TestInitialize]
        public virtual void Arrange()
        {
            Service = new FakeFunkyFadzService();

            Controller = new FunkyFadzController(
            new Lazy<IFunkyFadzService>(() => Service));
        }
    }
}

