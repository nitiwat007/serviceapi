using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAPI.Models;

namespace ServiceAPI.Interfaces
{
    public interface IFacultyBLL
    {
        IEnumerable<FacultyModel> GetFaculty();
        IEnumerable<FacultyModel> GetFacultyByName(string name);
        FacultyModel GetFacultyByID(string ID);
    }
}
