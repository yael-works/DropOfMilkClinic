using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.IServices
{
    public interface INurseService
    {
        public IEnumerable<Nurse> Get();

        public string Get(string Fname, string Lname);
        

    }
}
