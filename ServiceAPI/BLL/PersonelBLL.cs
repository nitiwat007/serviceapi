using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceAPI.Interfaces;
using ServiceAPI.Models;

namespace ServiceAPI.BLL
{
    public class PersonelBLL : IPersonelBLL
    {
        IPersonelRepository Ipr =new ServiceAPI.Repositories.PersonelOracleRepository();

        public PersonelBLL()
        {
            
        }

        public IEnumerable<PersonelModel> GetStaff()
        {
            return Ipr.GetStaff();
        }

        public PersonelModel GetStaffByID(string ID)
        {
            return Ipr.GetStaffByID(ID);
        }

        public List<PersonelModel> GetStaffByName(string name)
        {
            return Ipr.GetStaffByName(name);
        }
    
    }
}