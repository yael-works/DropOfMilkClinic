
using DropOfMilkClinic.Core.IServices;
using DropOfMilkClinic.Data.Repositories;
using DropOfMilkClinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Serivce
{
    public class RecommendationService: IRecommandationService
    {
        private readonly IRecommendationRepository _recommendationRepository;

        public RecommendationService(IRecommendationRepository recommendationRepository)
        {
            _recommendationRepository = recommendationRepository;
        }

        public IEnumerable<Recommendation> Get()
        {
            return _recommendationRepository.Get();
        }




        // GET api/<RecommendationController>?keyword=somekeyword
        //[HttpGet"{id}"]
        //פונקציה שמחזירה לי את כל ההמלצות שמוכל בהם מילת חיפוש של המשתמש


    }


}
