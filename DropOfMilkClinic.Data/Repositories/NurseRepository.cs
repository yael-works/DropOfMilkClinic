using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//תקינות קלט לא נקבל גיל מעל 3
namespace DropOfMilkClinic.Data.Repositories
{
    public class NurseRepository : INurseRespository
    {
        private readonly DataContex _context;
        private readonly DataContex _branch;

        public NurseRepository(DataContex context, DataContex branch)
        {
            _context = context;
            _branch = branch;
        }
        public List<Nurse> GetAll()
        {
            return _context.Nurse.Include(n=>n.Branch).ToList();
        }

        //public List<Nurse> GetNursesByBranchId(int branchId)
        //{
        //    // שליפת אחיות השייכות לסניף המבוקש
        //    return _context.Nurse
        //        .Where(n => n.BranchId != null && n.BranchId == branchId)
        //        .ToList();
        //}
        //    public List<Nurse> GetNursesByCityAndStreet(string city, string street)
        //    {
        //        // ולידציה של העיר
        //        if (string.IsNullOrEmpty(city))
        //        {
        //            throw new ArgumentException("City cannot be null or empty.");
        //        }

        //        // טוען את כל הסניפים בעיר המסוננת
        //        List<Branch> branches = _context.Branch
        //                                        .Where(b => b.City == city && b.status == true)
        //                                        .ToList();

        //        // אם אין סניפים מתאימים לעיר, מחזירים רשימה ריקה
        //        if (!branches.Any())
        //        {
        //            return new List<Nurse>();
        //        }

        //        if (string.IsNullOrEmpty(street))
        //        {
        //            // אם הרחוב ריק, מחזירים את כל האחיות מכל הסניפים בעיר
        //            return _context.Nurse
        //                .Where(n => branches.Select(b => b.BranchId).Contains(n.BranchId) && n.Status == true)
        //                .ToList();
        //        }
        //        else
        //        {
        //            // סינון לפי סניף ברחוב המבוקש
        //            Branch filteredBranch = branches
        //                .FirstOrDefault(b => b.Street == street);

        //            if (filteredBranch != null)
        //            {
        //                // מחזירים את כל האחיות ששייכות לסניף המסונן
        //                return _context.Nurse
        //                    .Where(n => n.BranchId == filteredBranch.BranchId && n.Status == true)
        //                    .ToList();
        //            }
        //        }

        //        // אם לא נמצא סניף תואם לרחוב, מחזירים רשימה ריקה
        //        return new List<Nurse>();
        //    }
        //
    }
}
