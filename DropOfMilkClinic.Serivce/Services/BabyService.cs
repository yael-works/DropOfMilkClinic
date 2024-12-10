using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//כאן יהיה החלק של התנאים
//חישביים בSERVICE ולגשת לנתונים זה בDATA
namespace DropOfMilkClinic.Services
{
    public class BabyService: IBabyService
    {
        private readonly IBabyRespository _babyRespository;
        


       public BabyService(IBabyRespository babyRespository)
        {
            _babyRespository = babyRespository;
        }

        public List<Baby> GetList()
        {
            return _babyRespository.GetAll();
        }

        public Baby GetById(string id)
        {
            //חישוב
            //לדוגמא אפשר לבדוק תאריך לידה \ גיל על תלמידה הנוכחית
            return _babyRespository.GetById(id);
        }

        public void Add(Baby b)
        {
           if(_babyRespository.GetById(b.BabyId)!=null)         
                throw new Exception($"Baby with ID {b.BabyId} already exists.");

          _babyRespository.Add(b);
        }

        //public List<Turn> GetTurnList(string babyId)
        //{
        //    // קריאה ל-Repository כדי לקבל את רשימת התורים
        //    var turns = _babyRespository.GetTurnList(babyId);

        //    // כאן תוכלי להוסיף לוגיקה נוספת אם צריך (לדוגמה: סינון, עיבוד וכו')
        //    return turns;
        //}
        public void ToggleLeaveStatus(string id)
        {
            var baby = _babyRespository.GetById(id);
            if (baby == null)
            {
                throw new Exception($"Baby with ID {id} not found.");
            }

            // שינוי הסטטוס של התינוק בין true ל-false (הפוך את הערך הקיים)
            baby.IsBaby = !baby.IsBaby;

            // עדכון התינוק ב-Repository
            _babyRespository.Update(baby);
        }

        // פונקציה לעדכון הסניף של התינוק
        //public void UpdateBranch(string babyId, int branchId)
        //{
        //    var baby = _babyRespository.GetById(babyId);
        //    if (baby == null)
        //    {
        //        throw new Exception($"Baby with ID {babyId} not found.");
        //    }

        //    var branch = _babyRespository.GetBranchById(branchId);
        //    if (branch == null)
        //    {
        //        throw new Exception($"Branch with ID {branchId} not found.");
        //    }

        //    baby.BranchId = branch.BranchId; // עדכון הסניף
        //    _babyRespository.Update(baby); // עדכון התינוק ב-Repository
        //}
        //public void AddTurnToBaby(string babyId, string turnId)
        //{
        //    // קבלת התינוק לפי מזהה
        //    var baby = _babyRespository.GetById(babyId);
        //    if (baby == null)
        //    {
        //        throw new Exception($"Baby with ID {babyId} not found.");
        //    }

        //    // בדיקה אם התור קיים
        //    var turn = _babyRespository.GetTurnById(turnId);
        //    if (turn == null)
        //    {
        //        throw new Exception($"Turn with ID {turnId} not found.");
        //    }

        //    // בדיקה אם הסניף של התור תואם לסניף של התינוק
        //    if (baby.BranchId != turn.BranchId)
        //    {
        //        throw new Exception($"Turn with ID {turnId} belongs to a different branch than baby with ID {babyId}.");
        //    }

        //    // בדיקה אם התור כבר קיים ברשימת התורים של התינוק
        //    if (baby.BabyTurns.Any(t => t.TurnId == turnId))
        //    {
        //        throw new Exception($"Turn with ID {turnId} already exists for baby with ID {babyId}.");
        //    }

        //    // הוספת התור לתינוק
        //    _babyRespository.AddTurnToBaby(babyId, turn.TurnId);
        //}

        //public void RemoveTurnFromBaby(string babyId, string turnId)
        //{
        //    var baby = _babyRespository.GetById(babyId);
        //    if (baby == null)
        //    {
        //        throw new Exception($"Baby with ID {babyId} not found.");
        //    }
            
        //    var turn = baby.BabyTurns.FirstOrDefault(t => t.TurnId == turnId);
        //    if (turn == null)
        //    {
        //        throw new Exception($"Turn with ID {turnId} not found for baby with ID {babyId}.");
        //    }

        //    _babyRespository.RemoveTurnFromBaby(babyId, turnId);
        //}



    }
}
