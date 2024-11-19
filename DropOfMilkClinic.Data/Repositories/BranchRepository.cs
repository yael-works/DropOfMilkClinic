using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//תקינות קלט לא נקבל גיל מעל 3
namespace DropOfMilkClinic.Data.Repositories
{
   public class BranchRepository: IBranchRepository
    {
        private readonly DataContex _context;
        public BranchRepository(DataContex context)
        {
            _context = context;
        }

        public IEnumerable<Branch> Get()
            {
                return _context.Branch;
            }

            public string GetById(int id)
            {
                var index = _context.Branch.FindIndex(e => e.BranchId == id && _context.Branch[_context.Branch.FindIndex(e => e.BranchId == id)].status);
                return _context.Branch[index].City + " " + _context.Branch[index].Street;
            }
          
            public List<string> GetByCity(string city)
            {
                var relevantTurns = _context.Branch.Where(e => e.City == city && _context.Branch[_context.Branch.FindIndex(e => e.City == city)].status)
                                     .Select(e => e.Street + " " + e.BranchId)
                                     .ToList();

                // בודק אם נמצאו תורים
                if (relevantTurns.Count == 0)
                {
                    return null;
                }

                return relevantTurns;
            }
        }

    public interface IBranchRepository
    {
    }
}
