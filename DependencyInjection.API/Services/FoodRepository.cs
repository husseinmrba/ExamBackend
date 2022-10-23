using DependencyInjection.API.DataAccess;
using DependencyInjection.API.Models;
using DependencyInjection.API.Services.Interfaces;

namespace DependencyInjection.API.Services
{
    public class FoodRepository : IFoodRepository
    {
        public Food AddFood(string name, int price)
        {
            var lastExistingFoodId = FoodDataStore.Current.Foods.Max(f => f.Id);
            var food = new Food()
            {
                Id = ++lastExistingFoodId,
                Name = name,
                Price = price
            };
            FoodDataStore.Current.Foods.Add(food);
            return food;
        }
    }
}
