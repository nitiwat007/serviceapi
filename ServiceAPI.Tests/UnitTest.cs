using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceAPI.Repositories;
using ServiceAPI.Interfaces;
using ServiceAPI.BLL;
using System.Linq;


namespace ServiceAPI.Tests
{

    [TestClass]
    public class UnitTest
    {

        [TestCategory("Staff"), TestMethod]
        public void TestGetStaff()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();

            int getStaff = PersonelBLL.GetStaff().Count();

            Assert.AreNotEqual(0, getStaff);
        }

        [TestCategory("Staff"), TestMethod]
        public void TestGetStaffByName()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();

            int getStaff = PersonelBLL.GetStaffByName("นิติ").Count;

            Assert.AreNotEqual(1, getStaff);
        }

        [TestCategory("Staff"), TestMethod]
        public void TestGetStaffByID()
        {
            IPersonelBLL PersonelBLL = new PersonelBLL();

            string StaffNameThai = PersonelBLL.GetStaffByID("0016508").StaffNameThai;

            Assert.AreEqual("นิติวัฒน์", StaffNameThai);
        }

        [TestCategory("Faculty"),TestMethod]
        public void TestGetFaculty()
        {
            IFacultyBLL FacultyBLL = new FacultyBLL();

            int getFaculty = FacultyBLL.GetFaculty().Count();

            Assert.AreNotEqual(0, getFaculty);
        }

        [TestCategory("Faculty"), TestMethod]
        public void TestGetFacultyByID()
        {
            IFacultyBLL FacultyBLL = new FacultyBLL();

            string FacultyNameThai = FacultyBLL.GetFacultyByID("48").FacultyNameThai;

            Assert.AreEqual("คณะเทคโนโลยีและสิ่งแวดล้อม", FacultyNameThai);
        }

        [TestCategory("Faculty"), TestMethod]
        public void TestGetFacultyByName()
        {
            IFacultyBLL FacultyBLL = new FacultyBLL();

            int getFaculty = FacultyBLL.GetFacultyByName("คณะ").Count();

            Assert.AreNotEqual(1, getFaculty);
        }
    }
}
