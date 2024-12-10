using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Respositories
{
    public interface INurseRespository
    {
        public List<Nurse> GetAll();

        //public List<Nurse> GetNursesByBranchId(int branchId);

        //public List<Nurse> GetNursesByCityAndStreet(string city, string street);



    }
}
