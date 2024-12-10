using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Data.Repositories
{
    public class TurnRepository : ITurnRespository
    {
        private readonly DataContex _context;
        private readonly DataContex _branch;
        public TurnRepository(DataContex context, DataContex b)
        {
            _context = context;
            _branch = b;
        }


        public List<Turn> GetTurnsByDate(DateTime date)
        {
            //thenInclude
            // שליפת כל התורים בתאריך המבוקש
            return _context.Turn.ToList()
                .Where(t => t.TurnDate.Date == date.Date)
                .ToList();
        }
        //public List<Turn> GetTurnsByCityAndStreet(string city, string street)
        //{
        //    // טוען את כל הסניפים
        //    List<Branch> branches = _context.Branch.ToList();

        //    // סינון הסניפים הפנויים לפי עיר ורחוב
        //    Branch filteredBranche = branches
        //        .FirstOrDefault(b => b.City == city &&
        //                    b.Street == street &&
        //                    b.status ==true);  // סינון לפי סטטוס TRUE


        //    // שליפת התורים ששייכים לסניפים המסוננים
        //    return _context.Turn
        //        .Where(t => t.BranchId== filteredBranche.BranchId&&t.Status==false)  // אם התור שייך לסניף מהסניפים המסוננים
        //        .ToList();
        //}



    }
}
