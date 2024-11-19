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
        public IEnumerable<Branch> Get();

        public string GetById(int id);


        public List<string> GetByCity(string city);
       

    }
}
