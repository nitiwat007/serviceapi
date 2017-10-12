using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceAPI.Interfaces;
using ServiceAPI.Models;
using ServiceAPI.DataSources;

namespace ServiceAPI.Repositories
{
    public class FacultyPersonelOracleRepository : IFacultyRepository
    {

        PersonelOracleEntities db = new PersonelOracleEntities();

        public IEnumerable<FacultyModel> GetFaculty()
        {
            IEnumerable<FacultyModel> result = null;

            result = db.C_FACULTY.Where(x => x.CAMP_ID == "03")
                .Select(x => new FacultyModel
                {
                    FacID=x.FAC_ID,
                    FacultyNameThai=x.FAC_NAME_THAI,
                    FacultyNameEng=x.FAC_NAME_ENG
                }).AsQueryable();

            return result;
        }

        public FacultyModel GetFacultyByID(string ID)
        {
            FacultyModel result = null;

            result = db.C_FACULTY.Where(x => x.FAC_ID == ID)
                .Select(x => new FacultyModel
                {
                    FacID = x.FAC_ID,
                    FacultyNameThai = x.FAC_NAME_THAI,
                    FacultyNameEng = x.FAC_NAME_ENG
                }).SingleOrDefault();

            return result;
        }

        public IEnumerable<FacultyModel> GetFacultyByName(string name)
        {
            IEnumerable<FacultyModel> result = null;

            result = db.C_FACULTY.Where(x => x.CAMP_ID == "03" && x.FAC_NAME_THAI.Contains(name))
               .Select(x => new FacultyModel
               {
                   FacID = x.FAC_ID,
                   FacultyNameThai = x.FAC_NAME_THAI,
                   FacultyNameEng = x.FAC_NAME_ENG
               }).AsQueryable();

            return result;
        }
    }
}