using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService branchService;
        public BranchController(IBranchService _branchService)
        {
            this.branchService = _branchService;
        }

        // GET: api/<BranchController>
        [HttpGet]
        public IEnumerable<Branch> Get()
        {
            return branchService.Get();
        }

        // GET api/<BranchController>/5
        [HttpGet("id/{id}")]
        public string GetById(int id)
        {
           return branchService.GetById(id); 
        }
        // GET api/<BranchController>/5
        [HttpGet("city/{city}")]
        public List<string> GetByCity(string city)
        {
           return branchService.GetByCity(city);
        }
    }
    }

