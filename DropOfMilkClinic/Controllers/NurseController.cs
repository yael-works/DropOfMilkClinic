using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly INurseService nurseService;
        public NurseController(INurseService nurseService)
        {
            this.nurseService = nurseService;
        }
        // GET: api/<NurseController>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return nurseService.Get();
        }

        // GET api/<NurseController>/5
        [HttpGet("{Fname,Lname}")]
        public string Get(string Fname,string Lname)
        {
             return nurseService.Get(Fname, Lname); 
        }

    
      


    }
}
