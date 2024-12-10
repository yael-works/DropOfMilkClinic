using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Services
{
    public interface IBabyService
    {

        public List<Baby> GetList();
     

        public Baby GetById(string id);
       
       

        public void Add(Baby b);

      //  public List<Turn> GetTurnList(string babyId);

        public void ToggleLeaveStatus(string id);

       // public void UpdateBranch(string babyId, int branchId);

     //   public void AddTurnToBaby(string babyId, string turnId);

    //    public void RemoveTurnFromBaby(string babyId, string turnId);



    }
}
