using DropOfMilkClinic.Core.Services;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//כאן יהיה החלק של התנאים
//חישביים בSERVICE ולגשת לנתונים זה בDATA
namespace DropOfMilkClinic.Services
{
    public class BabyService: IBabyService
    {
        private readonly IBabyRepository _babyRespository;


       public BabyService(IBabyRepository babyRespository)
        {
            _babyRespository = babyRespository;
        }

        public string Get(string id)
        {
            return _babyRespository.Get(id)g;
        }
        public List<Turn> GetTurnList(string id)
        {
            return _babyRespository.GetTurnList(id);
        }


        public void Post(Baby value)
        {

            _babyRespository.Post(value);
        }

        public int Post(DateTime date, string id)
        {
            return _babyRespository.Post(date, id);
        }

        public void PutId(string id, bool value)
        {
            _babyRespository.PutId(id, value);

        }

        public IActionResult PutCity(string id, string city)
        {
            return _babyRespository.PutCity(id, city);
        }


        public void Delete(int turnId, string id)
        {
            _babyRespository.Delete(turnId, id);
        }

    }
}
