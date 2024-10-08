using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        public static List<Branch> branches = new List<Branch> {
            new Branch{BranchId=1,City="BNE BRAK",Street="RabyAkiva",status=true},
               new Branch{BranchId=2,City="RAMAT GAN",Street="SHOMRIM",status=false},
                  new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true}

        };
        // GET: api/<BranchController>
        [HttpGet]
        public IEnumerable<Branch> Get()
        {
            return branches;
        }

        // GET api/<BranchController>/5
        [HttpGet("id/{id}")]
        public string GetById(int id)
        {
            var index = branches.FindIndex(e => e.BranchId == id&&branches[branches.FindIndex(e=> e.BranchId==id)].status);
                return branches[index].City + " " + branches[index].Street;  
        }
        // GET api/<BranchController>/5
        [HttpGet("city/{city}")]
        public List<string> GetByCity(string city)
        {
            var relevantTurns = branches.Where(e => e.City == city && branches[branches.FindIndex(e => e.City == city)].status)
                                 .Select(e =>e.Street+" "+e.BranchId )
                                 .ToList();

            // בודק אם נמצאו תורים
            if (relevantTurns.Count == 0)
            {
                return null;
            }

            return relevantTurns;
        }
    }
    }

