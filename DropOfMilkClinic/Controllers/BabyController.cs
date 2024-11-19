using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private readonly IBabyService babyService;
        public BabyController(IBabyService babyService)
        {
            this.babyService = babyService;
        }

        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
           return babyService.Get(id);
        }
        //// GET api/<BabyController>/5
        //[HttpGet("{turn}")]
        //public List<Turn> GetTurnList(string id)
        //{
        //    return babyService.GetTurnList(id);
        //}



        [HttpGet("{id}/turn")]
    public IActionResult GetTurnList(string id)
    {
            return babyService.GetTurnList(id);
    }

    // POST api/<BabyController>
    [HttpPost]
        public void Post([FromBody] Baby value)
        {
           babyService.Post(value);
        }
        // POST api/<BabyController>
        [HttpPost("{date}")]
        public int Post(DateTime date, string id)
        {
            return babyService.Post(date, id);
        }
        // PUT api/<BabyController>/5
        [HttpPut("id/{id}")]
        public void PutId(string id, [FromBody] bool value)
        {
           babyService.PutId(id, value);
        }

        // PUT api/<YourController>/baby/{branch}
        [HttpPut("branchId/{city}")]
        public IActionResult PutCity(string id, string city)
        {
            return babyService.PutCity(id, city);
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{turnId}")]
        public void Delete(int turnId,string id)
        {
           babyService.Delete(turnId, id);
        }
    }
}
