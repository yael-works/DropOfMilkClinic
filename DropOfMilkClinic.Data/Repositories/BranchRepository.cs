using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//תקינות קלט לא נקבל גיל מעל 3
namespace DropOfMilkClinic.Data.Repositories
{
    public class BranchRepository : IBranchRespository
    {
        private readonly DataContex _context;
        public BranchRepository(DataContex context)
        {
            _context = context;
        }

        public List<Branch> GetAll()
        {
            return _context.Branch.ToList();
        }


        public List<Branch> GetBranchesByCity(string city)
        {
            // סינון סניפים לפי עיר וסטטוס TRUE
            return _context.Branch
                           .Where(b => b.City == city && b.Status == true)
                           .ToList();
        }
    }
}
