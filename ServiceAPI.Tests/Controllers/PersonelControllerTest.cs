using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI.Controllers;
using ServiceAPI.Models;
using System.Linq;

namespace ServiceAPI.Tests.Controllers
{
    /// <summary>
    /// Summary description for PersonelControllerTest
    /// </summary>
    [TestClass]
    public class PersonelControllerTest
    {

        [TestMethod]
        public void GetByName()
        {
            PersonelController controller = new PersonelController();

            IEnumerable<PersonelModel> result = controller.GetByName("นิติวัฒน์");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }

        [TestMethod]
        public void GetById()
        {
            PersonelController controller = new PersonelController();

            string result = controller.Get("0016508").StaffNameThai;

            Assert.IsNotNull(result);
            Assert.AreEqual("นิติวัฒน์", result);
        }
    }
}
