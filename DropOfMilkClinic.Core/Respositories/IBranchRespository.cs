using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Respositories
{
    public interface IBranchRespository
    {
        public List<Branch> GetAll();


        public List<Branch> GetBranchesByCity(string city);

 

    }
}
