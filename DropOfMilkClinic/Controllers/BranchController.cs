using DropOfMilkClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly DataContex _context;

        public BranchController(DataContex context)
        {
            _context = context;
        }
        // GET: api/<BranchController>
        [HttpGet]
        public IEnumerable<Branch> Get()
        {
            return _context.Branch;
        }

        // GET api/<BranchController>/5
        [HttpGet("id/{id}")]
        public string GetById(int id)
        {
            var index = _context.Branch.FindIndex(e => e.BranchId == id&&_context.Branch[_context.Branch.FindIndex(e=> e.BranchId==id)].status);
                return _context.Branch[index].City + " " + _context.Branch[index].Street;  
        }
        // GET api/<BranchController>/5
        [HttpGet("city/{city}")]
        public List<string> GetByCity(string city)
        {
            var relevantTurns = _context.Branch.Where(e => e.City == city && _context.Branch[_context.Branch.FindIndex(e => e.City == city)].status)
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

