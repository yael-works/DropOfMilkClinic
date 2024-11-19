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
       
        public string Get(string id);

        public List<Turn> GetTurnList(string id);



        public void Post(Baby value);


        public int Post(DateTime date, string id);


        public void PutId(string id, bool value);


        public ActionResult PutCity(string id, string city);



        public void Delete(int turnId, string id);
       

    }
}
