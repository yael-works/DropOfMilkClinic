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
        private readonly IBranchRepository _branchRepository;
      
        public BranchService(IBranchRepository branchRespository)
        {
            _branchRepository = branchRespository;
        }

        public IEnumerable<Branch> Get()
        {
          return _branchRepository.Get();
        }

        public string GetById(int id)
        {
            return _branchRepository.GetById(id);
        }

        public List<string> GetByCity(string city)
        {
            return _branchRepository.GetByCity(city);
        }
    }
}
