using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceAPI.Models;
using ServiceAPI.Interfaces;

namespace ServiceAPI.BLL
{
    public class FacultyBLL : IFacultyBLL
    {
        IFacultyRepository Ifr = new ServiceAPI.Repositories.FacultyPersonelOracleRepository();

        public FacultyBLL()
        {

        }

        public IEnumerable<FacultyModel> GetFaculty()
        {
            return Ifr.GetFaculty();
        }

        public FacultyModel GetFacultyByID(string ID)
        {
            return Ifr.GetFacultyByID(ID);
        }

        public IEnumerable<FacultyModel> GetFacultyByName(string name)
        {
            return Ifr.GetFacultyByName(name);
        }
    }
}