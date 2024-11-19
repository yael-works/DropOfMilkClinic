using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Data.Repositories
{
    public class RecommendationRepository: IRecommendationRepository
    {

        private readonly DataContex _context;
        public RecommendationRepository(DataContex context)
        {
            _context = context;
        }   

        public IEnumerable<Recommendation> Get()
        {
            return _context.Recommedation;
        }




        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
        //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש

    }

    public interface IRecommendationRepository
    {
    }
}
