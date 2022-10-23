using DependencyInjection.API.DataAccess;
using DependencyInjection.API.Models;
using DependencyInjection.API.Services.Interfaces;

namespace DependencyInjection.API.Services
{
    public class MockFoodRepository : IFoodRepository
    {
        public Food AddFood(string name , int price)
        {
            var food = new Food()
            {
                Id = 0,
                Name = "Testing",
                Price = 0
            };
            return food;
        }
    }
}
