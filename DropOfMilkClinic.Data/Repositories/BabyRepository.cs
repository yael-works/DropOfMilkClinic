using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DropOfMilkClinic.Data.Repositories
{
    public class BabyRepository : IBabyRespository
    {
        private readonly DataContex _context;
        public BabyRepository(DataContex context)
        {
            _context = context;
        }

        public List<Baby> GetAll()
        {
            return  _context.Baby.Include(u =>u.Branch)
                                 .Where(x => x.IsBaby == true)
                                 .ToList();

        }


        public Baby GetById(string id)
        {
            return _context.Baby.ToList().Find(x => x.BabyId == id);
        }

        public void Add(Baby baby)
        {

            // הוספת התינוק לרשימה
            _context.Baby.Add(baby);
            _context.Entry(baby).State = EntityState.Added;
            _context.SaveChanges();
        }

        //public List<Turn> GetTurnList(string babyId)
        //{
        //    // בדיקת קיום התינוק לפי ה-BabyId
        //    var baby = _context.Baby.FirstOrDefault(b => b.BabyId == babyId);  // חיפוש התינוק לפי ה-BabyId
        //    if (baby == null)
        //    {
        //        throw new Exception($"Baby with ID {babyId} not found.");
        //    }

        //    // שליפת התורים של התינוק על פי רשימת ה-TurnId
        //    var turnList = baby.BabyTurns.ToList()
       // איפה שהססטוס של התור אמת?;
        //    return turnList;
        //}




        public void Update(Baby baby)
        {
            // חיפוש התינוק ברשימה לפי מזהה
            var existingBaby = _context.Baby.ToList().FirstOrDefault(b => b.BabyId == baby.BabyId);
            if (existingBaby != null)
            {
                // עדכון הסטטוס של התינוק
                existingBaby.IsBaby = baby.IsBaby;
            }
            else
            {
                throw new Exception($"Baby with ID {baby.BabyId} not found.");
            }
            _context.SaveChanges();
        }

        //// פונקציה להחזרת סניף לפי מזהה
        //public Branch GetBranchById(int branchId)
        //{
        //    return _context.Branch.FirstOrDefault(b => b.BranchId == branchId);
        //}
        //public Turn GetTurnById(string turnId)
        //{
        //    return _context.Turn.ToList().FirstOrDefault(t => t.TurnId == turnId);
        //}

        //public void AddTurnToBaby(string babyId, string turnId)
        //{
           
        //    Baby b = _context.Baby.ToList().FirstOrDefault(b => b.BabyId == babyId);
        //    Turn t = _context.Turn.ToList().FirstOrDefault(t => t.TurnId == turnId);
        //    b.BabyTurns.Add(t);
        //    _context.SaveChanges();
        //}

        //public void RemoveTurnFromBaby(string babyId, string turnId)
        //{
        //    // שליפת התינוק לפי ה-BabyId
        //    var baby = _context.Baby
        //                       .FirstOrDefault(b => b.BabyId == babyId);

        //    if (baby == null)
        //    {
        //        throw new Exception($"Baby with ID {babyId} not found.");
        //    }

        //    // שליפת הקשר מתוך רשימת BabyTurns והסרת התור לפי ה-TurnId
        //    Baby b = _context.Baby.ToList().FirstOrDefault(b => b.BabyId == babyId);
        //    Turn t= b.BabyTurns.FirstOrDefault(t => t.TurnId == turnId);

        //    if (t==null)
        //    {
        //        throw new Exception($"Turn with ID {turnId} not found for baby with ID {babyId}.");
        //    }
        //    b.BabyTurns.Remove(t);

        //    // שמירת שינויים במסד הנתונים
        //    _context.SaveChanges();
        //}







    }
}
