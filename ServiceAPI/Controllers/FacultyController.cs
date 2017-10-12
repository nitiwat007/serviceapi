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
    public class FacultyController : ApiController
    {

        IFacultyBLL Ifb = new FacultyBLL();

        // GET api/<controller>
        public IEnumerable<FacultyModel> Get()
        {
            IEnumerable<FacultyModel> Faculty = null;
            try
            {
                Faculty = Ifb.GetFaculty();
            }
            catch (Exception)
            {

                throw;
            }
            return Faculty;
        }

        // GET api/<controller>/5
        public FacultyModel Get(string id)
        {
            FacultyModel Faculty = null;

            try
            {
                Faculty = Ifb.GetFacultyByID(id);
            }
            catch (Exception)
            {

                throw;
            }

            return Faculty;
        }

        public IEnumerable<FacultyModel> GetByName(string name)
        {
            IEnumerable<FacultyModel> Faculty = null;

            try
            {
                Faculty = Ifb.GetFacultyByName(name);
            }
            catch (Exception)
            {

                throw;
            }

            return Faculty;
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
    }
}