using DependencyInjection.API.DataAccess;
using DependencyInjection.API.Models;
using DependencyInjection.API.Services;
using DependencyInjection.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly ILogger<FoodsController> _logger;
        private readonly IFoodRepository _foodRepository;

        public FoodsController(ILogger<FoodsController> logger , IFoodRepository foodRepository)
        {
            _logger = logger;
            _foodRepository = foodRepository;
        }

        [HttpGet]
        public ActionResult<List<Food>> GetFoods()
        {
            try
            {
                // throw exception
                //throw new FormatException();
                var foods = FoodDataStore.Current.Foods;
                _logger.LogInformation("Endpoint GetFoods done");
                return Ok(foods);
            }
            catch (Exception ex)
            {
                _logger.LogError("Endpoint GetFoods exception" , ex);
                return StatusCode(500 , "Endpoint GetFoods exception from server please try again");
            }
            
        }

        [HttpGet("{foodId}", Name = "GetFoodById")]
        public ActionResult<Food> GetFoodById(int foodId)
        {
            var food = FoodDataStore.Current.Foods.FirstOrDefault(p => p.Id == foodId);
            if (food == null)
                return NotFound();
            return Ok(food);
        }

        [HttpPost]
        public ActionResult<Food> CreateFood([FromQuery] string name , [FromQuery] int price)
        {
            var food = _foodRepository.AddFood(name, price);
            return CreatedAtRoute("GetFoodById", new { foodId = food.Id }, food);
        }
    }
}
