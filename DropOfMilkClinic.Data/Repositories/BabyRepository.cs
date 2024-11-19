using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//תקינות קלט לא נקבל גיל מעל 3
namespace DropOfMilkClinic.Data.Repositories
{
    public class BabyRepository: IBabyRepository
    {
        private readonly DataContex _context;
        public BabyRepository(DataContex context)
        {
            _context = context;
        }

        public string Get(string id)
        {
            var index = _context.Baby.FindIndex(e => e.BabyId == id);
            if (index == -1)
                return "NOT FOUND";
            return _context.Baby[index].FirstName + " " + _context.Baby[index].LastName + " " +
                _context.Baby[index].BranchId.City + _context.Baby[index].BranchId.Street;
        }
        public ActionResult GetTurnList(string id)
        {
            var baby = _context.Baby.FirstOrDefault(e => e.BabyId == id);

            if (baby == null)
            {
                return NotFound(); // מחזיר תשובה של לא נמצא אם לא נמצא תינוק
            }

            // מחזירים את רשימת ה-Turns של התינוק
            return Ok(baby.TurnIDList);
        }


        public void Post(Baby value)
        {
            _context.Baby.Add(value);
        }

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

        public void PutId(string id, bool value)
        {
            var index = _context.Baby.FindIndex(e => e.BabyId == id);
            _context.Baby[index].IsBaby = value;

        }

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


        public void Delete(int turnId, string id)
        {
            var Babyindex = _context.Baby.FindIndex(e => e.BabyId == id);
            var index = _context.Baby[Babyindex].TurnIDList.FindIndex(e => e.TurnId == turnId);
            if (index != -1)
            {
                _context.Turn[index].status = false;
                _context.Baby[Babyindex].TurnIDList.Remove(_context.Baby[Babyindex].TurnIDList[index]);

            }


        }
    }

    public interface IBabyRepository
    {
    }
}
