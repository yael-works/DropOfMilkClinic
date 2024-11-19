using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.IServices
{
    public interface IBabyService
    {
       
        public string Get(string id);

        public ActionResult GetTurnList(string id);



        public void Post(Baby value);


        public int Post(DateTime date, string id);


        public void PutId(string id, bool value);


        public IActionResult PutCity(string id, string city);



        public void Delete(int turnId, string id);
       

    }
}
