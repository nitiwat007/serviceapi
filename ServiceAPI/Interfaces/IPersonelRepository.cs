using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAPI.Models;

namespace ServiceAPI.Interfaces
{
    public interface IPersonelRepository
    {
        List<PersonelModel> GetStaffByName(string name);
        PersonelModel GetStaffByID(string ID);
    }
}
