using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.IRespositories
{
    public interface IRecommendationRespository
    {
        public IEnumerable<Recommendation> Get();

        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
        //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש
    }
}
