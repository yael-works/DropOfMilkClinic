using DropOfMilkClinic.Core.Services;
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
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(nurseService.GetList());
        }
        //[HttpGet("byBranch/{branchId}")]
        //public ActionResult GetNursesByBranchId(int branchId)
        //{
        //    try
        //    {
        //        // קריאה לשירות
        //        var nurses = nurseService.GetNursesByBranchId(branchId);

        //        if (nurses == null || nurses.Count == 0)
        //        {
        //            return NotFound($"No nurses found for branch ID {branchId}.");
        //        }

        //        return Ok(nurses);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[HttpGet("byLocation")]
        //public ActionResult GetNursesByCityAndStreet([FromQuery]string city,  string street)
        //{
        //    try
        //    {
        //        // קריאה לשירות
        //        var nurses = nurseService.GetNursesByCityAndStreet(city, street);

        //        if (nurses == null || nurses.Count == 0)
        //        {
        //            return NotFound($"No nurses found in city {city}, street {street}.");
        //        }

        //        return Ok(nurses);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}






    }
}
