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


        // GET: api/<TurnController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return turnService.Get();
        }
        // GET api/turn/date/{date}
        [HttpGet("date/{date}")]
        public ActionResult<List<int>> GetTurnsByDate(DateTime date)
        {
            return turnService.GetTurnsByDate(date);
           }

            // GET api/turn/branch/{branchName}
            [HttpGet("branch/{branchId}")]
        public ActionResult<List<int>> GetTurnsByBranchId(int branchId)
        {
           return turnService.GetTurnsByBranchId(branchId);
        }

        //// PUT api/<TurnController>/5
        //[HttpPut("{turnId}")]
        //public void Put(int turnId,bool status)
        //{

        //    var index = _context.Turn.FindIndex(e => e.TurnId == turnId);
        //    if(index != -1)
        //    _context.Turn[index].status = status;
        //}

    }


}
