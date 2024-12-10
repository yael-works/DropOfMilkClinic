using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Serivce
{
    public class BranchService: IBranchService
    {
        private readonly IBranchRespository _branchRepository;
      
        public BranchService(IBranchRespository branchRespository)
        {
            _branchRepository = branchRespository;
        }


        public List<Branch> GetList()
        {
            return _branchRepository.GetAll();
        }

      

        public List<Branch> GetBranchesByCity(string city)
        {
            // ולידציה של העיר
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City name cannot be null or empty.");
            }

            // קריאה ל-Repository לשלוף את הסניפים עם סטטוס TRUE בלבד
            return _branchRepository.GetBranchesByCity(city);
        }

    }
}
