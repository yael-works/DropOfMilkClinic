using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Respositories
{
   public interface ITurnRespository
    {


        public List<Turn> GetTurnsByDate(DateTime date);
        //public List<Turn> GetTurnsByCityAndStreet(string city, string? street = null);


    }
}
