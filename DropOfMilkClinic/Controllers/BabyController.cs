using DropOfMilkClinic.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        private readonly DataContex _context;

        public BabyController(DataContex context)
        {
            _context = context;
        }




        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var index = _context.Baby.FindIndex(e => e.BabyId == id);
            if (index == -1)
                return " NOT FOUND";
            return _context.Baby[index].FirstName + " " + _context.Baby[index].LastName + " " + _context.Baby[index].BranchId.City + _context.Baby[index].BranchId.Street;
        }
        //        // GET api/<BabyController>/5
        //        [HttpGet("{turn}")]
        //        public List<Turn> GetTurnList(string id)
        //        {
        //            var index = _context.Baby.FindIndex(e => e.BabyId == id);
        //            if (index == -1)
        //                return null;
        //            return _context.Baby.Where(e => e.BabyId == id)
        //.Select(e => e.TurnIDList);
        //        }

    

    [HttpGet("{id}/turn")]
    public IActionResult GetTurnList(string id)
    {
        var baby = _context.Baby.FirstOrDefault(e => e.BabyId == id);

        if (baby == null)
        {
            return NotFound(); // מחזיר תשובה של לא נמצא אם לא נמצא תינוק
        }

        // מחזירים את רשימת ה-Turns של התינוק
        return Ok(baby.TurnIDList);
    }

    // POST api/<BabyController>
    [HttpPost]
        public void Post([FromBody] Baby value)
        {
            _context.Baby.Add(value);
        }
        // POST api/<BabyController>
        [HttpPost("{date}")]
        public int Post(DateTime date, string id)
        {

            var index = _context.Baby.FindIndex(e => e.BabyId == id);

            // בדוק אם התינוק נמצא
            if (index == -1)
            {
                return -1;
            }


            var dateOptaniol = _context.Turn.FirstOrDefault(e => e.TurnDate.Date == date.Date);

            if (dateOptaniol == null)
            {
                return -1;
            }


            _context.Baby[index].TurnIDList.Add(dateOptaniol);
            _context.Turn[index].status = true;

            return dateOptaniol.TurnId;

        }
        // PUT api/<BabyController>/5
        [HttpPut("id/{id}")]
        public void PutId(string id, [FromBody] bool value)
        {
            var index = _context.Baby.FindIndex(e => e.BabyId == id);
            _context.Baby[index].IsBaby = value;

        }

        // PUT api/<YourController>/baby/{branch}
        [HttpPut("branchId/{city}")]
        public IActionResult PutCity(string id, string city)
        {
            var index = _context.Baby.FindIndex(e => e.BabyId == id);

            // בדוק אם התינוק נמצא
            if (index == -1)
            {
                return NotFound($"Baby with ID {id} not found."); // מחזיר תשובה 404 אם לא נמצא תינוק
            }

            // נניח שיש לך רשימה של סניפים עם קשרים לעיר
            var branch = _context.Branch.FirstOrDefault(b => b.City.Equals(city, StringComparison.OrdinalIgnoreCase));

            if (branch == null)
            {
                return NotFound($"Branch not found for city: {city}."); // מחזיר תשובה 404 אם לא נמצא סניף לעיר
            }

            // כאן תוכל לעדכן את הפרטים של התינוק או לבצע את מה שצריך
            _context.Baby[index].BranchId = branch; // לדוגמה, מעדכן את ה-BranchId של התינוק

            return Ok($"Baby with ID {id} has been updated with branch {branch.BranchId} for city {city}."); // מחזיר תשובה 200
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{turnId}")]
        public void Delete(int turnId,string id)
        {
            var Babyindex = _context.Baby.FindIndex(e => e.BabyId == id);
           var index= _context.Baby[Babyindex].TurnIDList.FindIndex(e => e.TurnId == turnId);
            if (index != -1)
            {
                _context.Turn[index].status = false;
                _context.Baby[Babyindex].TurnIDList.Remove(_context.Baby[Babyindex].TurnIDList[index]);

            }


        }
    }
}
