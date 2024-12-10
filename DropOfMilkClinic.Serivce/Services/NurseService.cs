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
    public class NurseService: INurseService
    {
        private readonly INurseRespository _nurseRepository;

        public NurseService(INurseRespository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }

        public List<Nurse> GetList()
        {
            return _nurseRepository.GetAll();
        }

        //public List<Nurse> GetNursesByBranchId(int branchId)
        //{
        //    // בדיקת תקינות הקלט
        //    if (branchId <= 0)
        //    {
        //        throw new ArgumentException("Branch ID must be greater than zero.");
        //    }

        //    // קריאה ל-Repository לשליפת רשימת האחיות
        //    return _nurseRepository.GetNursesByBranchId(branchId);
        //}
        //public List<Nurse> GetNursesByCityAndStreet(string city, string street)
        //{
        //    // ולידציה של הקלט
        //    if (city==null || city==null)
        //    {
        //        throw new ArgumentException("City and street cannot be null or empty.");
        //    }

        //    // קריאה ל-Repository לשליפת רשימת האחיות
        //    return _nurseRepository.GetNursesByCityAndStreet(city, street);
        //}

    }
}
