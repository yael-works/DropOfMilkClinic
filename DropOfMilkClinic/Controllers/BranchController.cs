using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce;
using DropOfMilkClinic.Services;
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
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(branchService.GetList());
        }


        [HttpGet("byCity")]
        public ActionResult GetBranchesByCity([FromBody] string city)
        {
            try
            {
                // קריאה לשירות
                var branches = branchService.GetBranchesByCity(city);

                // אם לא נמצאו סניפים
                if (branches == null || branches.Count == 0)
                {
                    return NotFound($"No branches found for city {city} with status TRUE.");
                }

                // אם נמצאו סניפים
                return Ok(branches);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
      
      
        }
      
    }

}


