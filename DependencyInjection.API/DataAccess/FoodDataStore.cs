using DependencyInjection.API.Models;

namespace DependencyInjection.API.DataAccess
{
    public class FoodDataStore
    {
        private FoodDataStore()
        {
            Foods = new List<Food>()
            {
                new Food(){ Id =1 , Name = "rice" , Price = 200},
                new Food(){ Id =2 , Name = "chicken" , Price = 300},
                new Food(){ Id =3 , Name = "meat" , Price = 400},
                new Food(){ Id =4 , Name = "mulukhiyah" , Price = 500},
                new Food(){ Id =5 , Name = "broth" , Price = 600},
                new Food(){ Id =6 , Name = "pizza" , Price = 700},
            };
        }
        public List<Food> Foods { get; set; }

        private static FoodDataStore _current = null;

        //public static ProductDataStore Current { get; } = new ProductDataStore();
        public static FoodDataStore Current
        {
            get
            {
                if (_current == null)
                    _current = new FoodDataStore();
                return _current;

            }
        }
    }
}
