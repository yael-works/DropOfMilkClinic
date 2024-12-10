using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        private readonly ITurnService turnService;
        public TurnController(ITurnService turnService)
        {
            this.turnService = turnService;
        }
      
        [HttpGet("byDate")]
        public ActionResult GetTurnsByDate([FromQuery] DateTime date)
        {
            try
            {
                // קריאה לשירות
                var turns = turnService.GetTurnsByDate(date);

                if (turns == null || turns.Count == 0)
                {
                    return NotFound($"No turns found for date {date:yyyy-MM-dd}.");
                }

                return Ok(turns);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpGet("byLocation")]
        //public ActionResult GetTurnsByCityAndStreet([FromQuery] string city, [FromQuery] string? street = null)
        //{
        //    try
        //    {
        //        // קריאה לשירות
        //        var turns = turnService.GetTurnsByCityAndStreet(city, street);

        //        if (turns == null || turns.Count == 0)
        //        {
        //            return NotFound($"No turns found for city {city}" + (string.IsNullOrEmpty(street) ? "." : $" and street {street}."));
        //        }

        //        return Ok(turns);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}


    }


}
