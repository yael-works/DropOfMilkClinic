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
    public class TurnService: ITurnService
    {
        private readonly ITurnRespository _turnRepository;
        public TurnService(ITurnRespository turnRepository)
        {
            _turnRepository = turnRepository;
        }



        public List<Turn> GetTurnsByDate(DateTime date)
        {
            // ולידציה - בדיקה אם התאריך תקין
            if (date == default)
            {
                throw new ArgumentException("Invalid date provided.");
            }

            // קריאה ל-Repository לשליפת תורים לפי תאריך
            return _turnRepository.GetTurnsByDate(date);
        }
        //public List<Turn> GetTurnsByCityAndStreet(string city, string? street = null)
        //{
        //    // ולידציה של העיר
        //    if (string.IsNullOrWhiteSpace(city))
        //    {
        //        throw new ArgumentException("City name cannot be null or empty.");
        //    }

        //    // קריאה ל-Repository
        //    return _turnRepository.GetTurnsByCityAndStreet(city, street);
        //}




    }


}
