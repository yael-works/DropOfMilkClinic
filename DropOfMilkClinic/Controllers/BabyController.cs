using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Services;
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
        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(babyService.GetList());
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var b = babyService.GetById(id);
            if (b != null)
            {
                return Ok(b);
            }
            return NotFound();
        }

        //[HttpGet("{id}/turns")] // נתיב ייחודי ל-GetTurnList
        //public ActionResult GetTurnList(string id)
        //{
        //    try
        //    {
        //        // שליפת רשימת התורים עבור התינוק
        //        var turns = babyService.GetTurnList(id);

        //        // החזרת הרשימה
        //        return Ok(turns);
        //    }
        //    catch (Exception ex)
        //    {
        //        // החזרת שגיאה אם התינוק לא נמצא או כל שגיאה אחרת
        //        return NotFound(ex.Message);
        //    }
        //}

        [HttpPost]
        public ActionResult Post([FromBody] Baby b)
        {
            // בדיקה אם תינוק עם אותו מזהה כבר קיים
            var existingBaby = babyService.GetById(b.BabyId);
            if (existingBaby != null)
            {
                return Conflict("Baby with the same ID already exists.");
            }

            // יצירת אובייקט תינוק חדש ללא רשימת תורים
            var newBaby = new Baby
            {
                FirstName = b.FirstName,
                LastName = b.LastName,
                BabyId = b.BabyId,
                IsBaby = true,
                Branch=b.Branch ,
              //  BabyTurns = b.BabyTurns
            };

            // הוספת התינוק דרך השירות
            babyService.Add(newBaby);
            return Ok("Baby added successfully.");
        }

        // PUT api/<BabyController>/5/leave
        [HttpPut("{id}/update")]
        public IActionResult PutLeaveStatus(string id)
        {
            try
            {
                // קריאה לשירות כדי לעדכן את הסטטוס של התינוק
                babyService.ToggleLeaveStatus(id);
                return Ok($"Baby with ID {id} status updated successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // פעולה לעדכון סניף של תינוק
        //[HttpPut("{babyId}/updateBranch/{branchId}")]
        //public ActionResult UpdateBranch(string babyId, int branchId)
        //{
        //    try
        //    {
        //        babyService.UpdateBranch(babyId, branchId);
        //        return Ok($"Baby with ID {babyId} successfully updated with branch ID {branchId}");
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}
        ////הוספת תור בסניף
        //[HttpPost("{babyId}/addTurn/{turnId}")]
        //public ActionResult AddTurnToBaby(string babyId, string turnId)
        //{
        //    try
        //    {
        //        babyService.AddTurnToBaby(babyId, turnId);
        //        return Ok($"Turn with ID {turnId} added successfully to baby with ID {babyId}.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //מחיקת תור של התינוק
        //[HttpDelete("{babyId}/removeTurn/{turnId}")]
        //public ActionResult RemoveTurnFromBaby(string babyId, string turnId)
        //{
        //    try
        //    {
        //        babyService.RemoveTurnFromBaby(babyId, turnId);
        //        return Ok($"Turn with ID {turnId} removed successfully from baby with ID {babyId}.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}


    }
}
