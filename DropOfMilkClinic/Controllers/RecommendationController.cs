using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private static List<Recommendation> recommendations = new List<Recommendation> {
            new Recommendation{RecommendId=1,RecommendContent="Winter is coming, so hurry up to vaccinate your children"},
            new Recommendation{RecommendId=2,RecommendContent="vaccinate to your new baby is very important!!!"}
        };

        // GET: api/<RecommendationController>
        [HttpGet]
        public IEnumerable<Recommendation> Get()
        {
            return recommendations;
        }




        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
  //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש

}
}
