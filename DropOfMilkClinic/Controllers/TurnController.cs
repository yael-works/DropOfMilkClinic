using DropOfMilkClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    { public readonly DataContex _context;
        public TurnController(DataContex context)
        {
            _context = context;
        }

        // GET: api/<TurnController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return _context.Turn;
        }
        // GET api/turn/date/{date}
        [HttpGet("date/{date}")]
        public ActionResult<List<int>> GetTurnsByDate(DateTime date)
        {
            // מסנן את התורים לפי תאריך ומחזיר רק את מזהי התורים
            var indexTurns = _context.Turn.Where(e => e.TurnDate.Date == date.Date)
                                  .Select(e => e.TurnId)
                                  .ToList();

            // בודק אם נמצאו תורים
            if (indexTurns.Count == 0)
            {
                return NotFound(); // מחזיר 404 אם לא נמצאו תורים
            }

            return Ok(indexTurns); // מחזיר את רשימת מזהי התורים
           }

            // GET api/turn/branch/{branchName}
            [HttpGet("branch/{branchId}")]
        public ActionResult<List<int>> GetTurnsByBranchId(int branchId)
        {
            var indexTurns = _context.Turn.Where(e => e.BranchId.BranchId == branchId).Select(e => e.TurnId).ToList();

            if (indexTurns.Count == 0)
            {
                return NotFound(); // מחזיר 404 אם לא נמצאו תורים
            }

            return Ok(indexTurns); // מחזיר את רשימת קודי התורים
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
