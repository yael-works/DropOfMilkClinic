using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private static List<Nurse> nurses= new List<Nurse> {
           new Nurse{FirstName="YAEL",LastName="SHUKER",NurseId="215262626",Status=true,BranchId=new Branch{ } }
        };
        // GET: api/<NurseController>
        [HttpGet]
        public IEnumerable<Nurse> Get()
        {
            return nurses;
        }

        // GET api/<NurseController>/5
        [HttpGet("{Fname,Lname}")]
        public string Get(string Fname,string Lname)
        {

            if (nurses.FindIndex(e => e.FirstName == Fname) == nurses.FindIndex(e => e.LastName == Lname)&&
                nurses.FindIndex(e => e.FirstName == Lname) != -1 &&
                nurses[nurses.FindIndex(e => e.FirstName == Fname)].Status==true)
            {
                var index = nurses.FindIndex(e => e.FirstName == Fname);
                return nurses[index].FirstName + " " + nurses[index].LastName;
            }
            else return "NOT FOUND";


        }

    
      


    }
}
