using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Serivce
{
    public class TurnService: ITurnService
    {
        private readonly ITurnRepository _turnRepository;
        public TurnService(ITurnRepository turnRepository)
        {
            _turnRepository = turnRepository;
        }

        public IEnumerable<Turn> Get()
        {
            return _turnRepository.Get();
        }

        //public ActionResult<List<int>> GetTurnsByDate(DateTime date)
        //{
        //    // מסנן את התורים לפי תאריך ומחזיר רק את מזהי התורים
        //    var indexTurns = _context.Turn.Where(e => e.TurnDate.Date == date.Date)
        //                          .Select(e => e.TurnId)
        //                          .ToList();

        //    // בודק אם נמצאו תורים
        //    if (indexTurns.Count == 0)
        //    {
        //        return NotFound(); // מחזיר 404 אם לא נמצאו תורים
        //    }

        //    return Ok(indexTurns); // מחזיר את רשימת מזהי התורים
        //}


        //public ActionResult<List<int>> GetTurnsByBranchId(int branchId)
        //{
        //    var indexTurns = _context.Turn.Where(e => e.BranchId.BranchId == branchId).Select(e => e.TurnId).ToList();

        //    if (indexTurns.Count == 0)
        //    {
        //        return NotFound(); // מחזיר 404 אם לא נמצאו תורים
        //    }

        //    return Ok(indexTurns); // מחזיר את רשימת קודי התורים
        //}

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
