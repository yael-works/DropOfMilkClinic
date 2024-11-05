using DropOfMilkClinic.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        public readonly DataContex _context;
        public RecommendationController(DataContex context)
        {
            _context = context;
        }


        // GET: api/<RecommendationController>
        [HttpGet]
        public IEnumerable<Recommendation> Get()
        {
            return _context.Recommedation;
        }




        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
  //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש

}
}
