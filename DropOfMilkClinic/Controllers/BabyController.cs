using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {
        public static List<Baby> babies =
            new List<Baby> {
            new Baby { FirstName="TAMAR",LastName="LEVI",BabyId="327720439",IsBaby=true,BranchId= new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true},TurnIDList=new List<Turn>{new Turn{TurnId=102,TurnDate=new DateTime(),BranchId=new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true},status=true}
            }
            } };


        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var index = babies.FindIndex(e => e.BabyId == id);
            if (index == -1)
                return " NOT FOUND";
            return babies[index].FirstName + " " + babies[index].LastName + " " + babies[index].BranchId.City + babies[index].BranchId.Street;
        }
        //        // GET api/<BabyController>/5
        //        [HttpGet("{turn}")]
        //        public List<Turn> GetTurnList(string id)
        //        {
        //            var index = babies.FindIndex(e => e.BabyId == id);
        //            if (index == -1)
        //                return null;
        //            return babies.Where(e => e.BabyId == id)
        //.Select(e => e.TurnIDList);
        //        }

    

    [HttpGet("{id}/turn")]
    public IActionResult GetTurnList(string id)
    {
        var baby = babies.FirstOrDefault(e => e.BabyId == id);

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
            babies.Add(value);
        }
        // POST api/<BabyController>
        [HttpPost("{date}")]
        public int Post(DateTime date, string id)
        {

            var index = babies.FindIndex(e => e.BabyId == id);

            // בדוק אם התינוק נמצא
            if (index == -1)
            {
                return -1;
            }


            var dateOptaniol = TurnController.turns.FirstOrDefault(e => e.TurnDate.Date == date.Date);

            if (dateOptaniol == null)
            {
                return -1;
            }


            babies[index].TurnIDList.Add(dateOptaniol);
            TurnController.turns[index].status = true;

            return dateOptaniol.TurnId;

        }
        // PUT api/<BabyController>/5
        [HttpPut("id/{id}")]
        public void PutId(string id, [FromBody] bool value)
        {
            var index = babies.FindIndex(e => e.BabyId == id);
            babies[index].IsBaby = value;

        }

        // PUT api/<YourController>/baby/{branch}
        [HttpPut("branchId/{city}")]
        public IActionResult PutCity(string id, string city)
        {
            var index = babies.FindIndex(e => e.BabyId == id);

            // בדוק אם התינוק נמצא
            if (index == -1)
            {
                return NotFound($"Baby with ID {id} not found."); // מחזיר תשובה 404 אם לא נמצא תינוק
            }

            // נניח שיש לך רשימה של סניפים עם קשרים לעיר
            var branch = BranchController.branches.FirstOrDefault(b => b.City.Equals(city, StringComparison.OrdinalIgnoreCase));

            if (branch == null)
            {
                return NotFound($"Branch not found for city: {city}."); // מחזיר תשובה 404 אם לא נמצא סניף לעיר
            }

            // כאן תוכל לעדכן את הפרטים של התינוק או לבצע את מה שצריך
            babies[index].BranchId = branch; // לדוגמה, מעדכן את ה-BranchId של התינוק

            return Ok($"Baby with ID {id} has been updated with branch {branch.BranchId} for city {city}."); // מחזיר תשובה 200
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{turnId}")]
        public void Delete(int turnId,string id)
        {
            var Babyindex = babies.FindIndex(e => e.BabyId == id);
           var index= babies[Babyindex].TurnIDList.FindIndex(e => e.TurnId == turnId);
            if (index != -1)
            {
                TurnController.turns[index].status = false;
                babies[Babyindex].TurnIDList.Remove(babies[Babyindex].TurnIDList[index]);

            }


        }
    }
}
