using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Serivce
{
    public class NurseService: INurseService
    {
        private readonly INurseRepository _nurseRepository;

        public NurseService(INurseRepository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }

        public IEnumerable<Nurse> Get()
        {
            return _nurseRepository.Get();
        }


        public string Get(string Fname, string Lname)
        {

          return _nurseRepository.Get(Fname, Lname);

        }
    }
}
