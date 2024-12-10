using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Services
{
    public interface IBranchService
    {


        public List<Branch> GetList();


        public List<Branch> GetBranchesByCity(string city);



    }
}
