using WebApp.API.Models;

namespace WebApp.API.DataAccess
{
    public class ProductDataStore
    {
        private ProductDataStore()
        {
            Products = new List<Product>()
            {
                new Product(){ Id =1 , Name = "C++" , Price = 200},
                new Product(){ Id =2 , Name = "C#" , Price = 300},
                new Product(){ Id =3 , Name = "F#" , Price = 400},
                new Product(){ Id =4 , Name = "Html" , Price = 500},
                new Product(){ Id =5 , Name = "CSS" , Price = 600},
                new Product(){ Id =6 , Name = "Java Script" , Price = 700},
            };
        }
        public List<Product> Products { get; set; }

        private static ProductDataStore _current = null;

        //public static ProductDataStore Current { get; } = new ProductDataStore();
        public static ProductDataStore Current
        {
            get
            {
                if (_current == null)
                    _current = new ProductDataStore();
                return _current;
                
            }
        }
    }
}
