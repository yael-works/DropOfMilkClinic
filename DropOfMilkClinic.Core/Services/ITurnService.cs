using DropOfMilkClinic.Core.Respositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.Services
{
    public interface ITurnService
    {
      public List<Turn> GetTurnsByDate(DateTime date);


       // public List<Turn> GetTurnsByCityAndStreet(string city, string? street = null);

    }

}

