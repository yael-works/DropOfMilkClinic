using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Services
{
    public interface INurseService
    {

       
    public List<Nurse> GetList();

   //public List<Nurse> GetNursesByBranchId(int branchId);

        //public List<Nurse> GetNursesByCityAndStreet(string city, string street);


    }
}
