using DependencyInjection.API.Models;

namespace DependencyInjection.API.Services.Interfaces
{
    public interface IFoodRepository
    {

        Food AddFood(string name, int price);
    }
}
