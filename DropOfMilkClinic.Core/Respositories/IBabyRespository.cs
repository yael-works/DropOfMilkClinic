using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Respositories
{
    public interface IBabyRespository
    {
        public List<Baby> GetAll();
        public Baby GetById(string id);
        public void Add(Baby baby);

       // public List<Turn> GetTurnList(string babyId);

        public void Update(Baby baby);

        //public Branch GetBranchById(int branchId);

        //public Turn GetTurnById(string turnId);


       // public void AddTurnToBaby(string babyId, string turn);

      //  public void RemoveTurnFromBaby(string babyId, string turnId);


    }
}
