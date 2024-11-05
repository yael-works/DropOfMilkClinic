using DropOfMilkClinic.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly DataContex _context;

        public NurseController(DataContex context)
        {
            _context = context;
        }
        // GET: api/<NurseController>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return _context.Nurse;
        }

        // GET api/<NurseController>/5
        [HttpGet("{Fname,Lname}")]
        public string Get(string Fname,string Lname)
        {

            if (_context.Nurse.FindIndex(e => e.FirstName == Fname) == _context.Nurse.FindIndex(e => e.LastName == Lname)&&
                _context.Nurse.FindIndex(e => e.FirstName == Lname) != -1 &&
                _context.Nurse[_context.Nurse.FindIndex(e => e.FirstName == Fname)].Status==true)
            {
                var index = _context.Nurse.FindIndex(e => e.FirstName == Fname);
                return _context.Nurse[index].FirstName + " " + _context.Nurse[index].LastName;
            }
            else return "NOT FOUND";


        }

    
      


    }
}
