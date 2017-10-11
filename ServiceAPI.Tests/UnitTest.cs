using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI.Repositories;
using ServiceAPI.Interfaces;
using ServiceAPI.BLL;


namespace ServiceAPI.Tests
{

    [TestClass]
    public class UnitTest
    {   

        [TestMethod]
        public void TestGetStaff()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();
            int getStaff = PersonelBLL.GetStaffByName("นิติ").Count;

            Assert.AreNotEqual(0, getStaff);

        }


        [TestMethod]
        public void TestGetStaffByName()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();

            int getStaff = PersonelBLL.GetStaffByName("นิติ").Count;

            Assert.AreNotEqual(1, getStaff);
        }

        [TestMethod]
        public void TestGetStaffByID()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();

            string StaffNameThai = PersonelBLL.GetStaffByID("0016508").StaffNameThai;

            Assert.AreEqual("นิติวัฒน์", StaffNameThai);
        }
    }
}
