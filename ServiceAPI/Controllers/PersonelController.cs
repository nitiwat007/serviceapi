using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceAPI.Interfaces;
using ServiceAPI.BLL;
using ServiceAPI.Models;
using ServiceAPI.Security;

namespace ServiceAPI.Controllers
{
    [BasicAuthentication]
    public class PersonelController : ApiController
    {

        IPersonelBLL Ipb = new PersonelBLL();

        // GET api/<controller>
        public IEnumerable<PersonelModel> Get()
        {
            IEnumerable<PersonelModel> Staff = null;
            try
            {
                Staff = Ipb.GetStaff();
            }
            catch (Exception)
            {

                throw;
            }
            return Staff;
        }

        // GET api/<controller>/
        public PersonelModel Get(string ID)
        {
            
            PersonelModel Staff = null;
            try
            {
                Staff=Ipb.GetStaffByID(ID);
            }
            catch (Exception)
            {

                throw;
            }

            return Staff;
        }

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

        // GET api/<controller>?name={name}
        public IEnumerable<PersonelModel> GetByName(string name)
        {
            IEnumerable<PersonelModel> Staff = null;
            
            try
            {
                Staff = Ipb.GetStaffByName(name);
            }
            catch (Exception)
            {

                throw;
            }

            return Staff;
        }
    }
}