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
        public IEnumerable<Nurse> Get();
        public string Get(string Fname, string Lname);
    }
}
