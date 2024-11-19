using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//תקינות קלט לא נקבל גיל מעל 3
namespace DropOfMilkClinic.Data.Repositories
{
    public class NurseRepository: INurseRepository
    {
        private readonly DataContex _context;
        public NurseRepository(DataContex context)
        {
            _context = context;
        }

        public IEnumerable<Nurse> Get()
        {
            return _context.Nurse;
        }

       
        public string Get(string Fname, string Lname)
        {

            if (_context.Nurse.FindIndex(e => e.FirstName == Fname) == _context.Nurse.FindIndex(e => e.LastName == Lname) &&
                _context.Nurse.FindIndex(e => e.FirstName == Lname) != -1 &&
                _context.Nurse[_context.Nurse.FindIndex(e => e.FirstName == Fname)].Status == true)
            {
                var index = _context.Nurse.FindIndex(e => e.FirstName == Fname);
                return _context.Nurse[index].FirstName + " " + _context.Nurse[index].LastName;
            }
            else return "NOT FOUND";


        }
    }

    public interface INurseRepository
    {
    }
}
