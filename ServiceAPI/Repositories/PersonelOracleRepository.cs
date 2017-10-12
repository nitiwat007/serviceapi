using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceAPI.Models;
using ServiceAPI.DataSources;
using ServiceAPI.Interfaces;

namespace ServiceAPI.Repositories
{
    public class PersonelOracleRepository : IPersonelRepository
    {
        PersonelOracleEntities db = new PersonelOracleEntities();

        public IEnumerable<PersonelModel> GetStaff()
        {
            return db.P_STAFF.Join(db.C_TITLE, p_staff => p_staff.TITLE_ID, c_title => c_title.TITLE_ID, (p_staff, c_title) => new { p_staff, c_title })
                .Where(x => x.p_staff.STAFF_DEPART == "3")
                .Select(x => new PersonelModel
                {
                    StaffID = x.p_staff.STAFF_ID,
                    TitleNameThai = x.c_title.TITLE_NAME_THAI,
                    StaffNameThai = x.p_staff.STAFF_NAME_THAI,
                    StaffSnameThai = x.p_staff.STAFF_SNAME_THAI,
                    TitleNameEng=x.c_title.TITLE_SHORT_ENG,
                    StaffNameEng=x.p_staff.STAFF_NAME_ENG,
                    StaffSnameEng=x.p_staff.STAFF_SNAME_ENG
                    
                }).AsQueryable();
        }

        public PersonelModel GetStaffByID(string ID)
        {
            return db.P_STAFF.Join(db.C_TITLE, p_staff => p_staff.TITLE_ID, c_title => c_title.TITLE_ID, (p_staff, c_title) => new { p_staff, c_title })
                .Where(x => x.p_staff.STAFF_ID==ID && x.p_staff.STAFF_DEPART == "3")
                .Select(x => new PersonelModel
                {
                    StaffID = x.p_staff.STAFF_ID,
                    TitleNameThai = x.c_title.TITLE_NAME_THAI,
                    StaffNameThai = x.p_staff.STAFF_NAME_THAI,
                    StaffSnameThai = x.p_staff.STAFF_SNAME_THAI,
                    TitleNameEng = x.c_title.TITLE_SHORT_ENG,
                    StaffNameEng = x.p_staff.STAFF_NAME_ENG,
                    StaffSnameEng = x.p_staff.STAFF_SNAME_ENG

                }).SingleOrDefault();
        }

        public List<PersonelModel> GetStaffByName(string name)
        {
            return db.P_STAFF.Join(db.C_TITLE, p_staff => p_staff.TITLE_ID, c_title => c_title.TITLE_ID, (p_staff, c_title) => new { p_staff, c_title })
                .Where(x => x.p_staff.STAFF_NAME_THAI.Contains(name) && x.p_staff.STAFF_DEPART == "3")
                .Select(x => new PersonelModel
                {
                    StaffID = x.p_staff.STAFF_ID,
                    TitleNameThai = x.c_title.TITLE_NAME_THAI,
                    StaffNameThai = x.p_staff.STAFF_NAME_THAI,
                    StaffSnameThai = x.p_staff.STAFF_SNAME_THAI,
                    TitleNameEng = x.c_title.TITLE_SHORT_ENG,
                    StaffNameEng = x.p_staff.STAFF_NAME_ENG,
                    StaffSnameEng = x.p_staff.STAFF_SNAME_ENG

                }).ToList();
        }
    }
}