using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ServiceAPI.Controllers;
using ServiceAPI.Models;

namespace ServiceAPI.Tests.Controllers
{
    /// <summary>
    /// Summary description for FacultyControllerTest
    /// </summary>
    [TestClass]
    public class FacultyControllerTest
    {
        [TestCategory("FacultyController"), TestMethod]
        public void GetFaculty()
        {
            FacultyController controller = new FacultyController();
            IEnumerable<FacultyModel> result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreNotEqual(0, result.Count());
        }

        [TestCategory("FacultyController"), TestMethod]
        public void GetById()
        {
            FacultyController controller = new FacultyController();
            string result = controller.Get("48").FacultyNameThai;

            Assert.IsNotNull(result);
            Assert.AreEqual("คณะเทคโนโลยีและสิ่งแวดล้อม", result);
        }

        [TestCategory("FacultyController"), TestMethod]
        public void GetByName()
        {
            FacultyController controller = new FacultyController();
            IEnumerable<FacultyModel> result = controller.GetByName("คณะเทคโนโลยีและสิ่งแวดล้อม");

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
        }
    }
}
