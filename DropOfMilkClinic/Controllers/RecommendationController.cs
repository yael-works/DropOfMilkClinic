﻿using DropOfMilkClinic.Entities;
using DropOfMilkClinic.Serivce;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DropOfMilkClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {
        private readonly IRecommendationService recommendationService;
        public RecommendationController(IRecommendationService recommendationService)
        {
            this.recommendationService = recommendationService;
        }

        // GET: api/<RecommendationController>
        [HttpGet]
        public IEnumerable<Recommendation> Get()
        {
            return recommendationService.Get();
        }

        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
  //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש

}
}
