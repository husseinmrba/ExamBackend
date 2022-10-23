using System.Collections.Generic;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lamda expression
            //var addition = (int x , int y) => x + y;

            // ordering
            var products = GetProducts();
            var order = products.OrderBy(p => p.Id).ToList();
            var orderDisc = products.OrderByDescending(p => p.Id).ToList();
            var orderTwoProperty = products.OrderBy(p => p.Id)
                                            .ThenBy(p => p.Name)
                                            .ToList();
            // Where
            var productsWhere = products.Where(p => p.City.Contains("afrin")).ToList();
            // Sum
            var sumPrice = products.Where(p => p.Id > 5).Sum(p => p.Price);
            // Max && Min
            var maxPrice = products.Max(p => p.Price);
            var minPrice = products.Min(p => p.Price);
            // GroubBy
            var groupByCity = products.GroupBy(p => p.City).ToList();
            // first/last product
            var firstProduct = products.FirstOrDefault();
            var lastProduct = products.LastOrDefault();
            if (firstProduct != null)
                Console.WriteLine("existing top product");
            // found single product
            //var single = products.SingleOrDefault(p => p.Id == 1); // Exception
            var single2 = products.SingleOrDefault(p => p.Id == 2);
            // check existing product
            var existing = products.Exists(p => p.Name.Contains("C++"));
            // Select
            var productsIdAndName = products.Select(p => new { p.Id , p.Name}).ToList();
            var cities = products.Select(p => p.City)
                                 .Distinct()
                                 .ToList();
            // multi
            int[] numbers = new int[] { 1, 2, 3 };
            var multi = numbers.Aggregate((a, b) => a * b);
            // Comma seperated
            string commaNames = products.Select(p => p.Name)
                                    .ToArray()
                                    .Aggregate((a,b) => a + " , " + b);
            // return product index
            var sequence = products.Select((p, index) => new { Id = p.Id, Name = p.Name, Seq = index }).ToList();
            // SelectMany
            var colors = products.SelectMany(p => p.Colors).Distinct().ToList();
            // take 5 product
            var fisrtFiveProduct = products.Take(5).ToList();
            // takeWhile
            var takeWhile = products.TakeWhile(p => p.Price < 15).ToList();
            // Skip
            var skip = products.Skip(1).ToList();
            //SkipWhile
            var skipWhile = products.SkipWhile(p => p.Id <= 5).ToList();
            // Union & Intersect & Except
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[] { 3, 4, 5 };
            var union = arr1.Union(arr2).ToArray(); // 1  2  3  4  5  
            var intersect = arr1.Intersect(arr2).ToArray(); // 3
            var except = arr1.Except(arr2).ToArray(); // 1  2

        }



        static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(1,"Csharp","Idlib",11.2,new List<string>(){"red","blue","green"}),
                new Product(2,"C++","Aleppo",9.8,new List<string>(){"pink","blue","green"}),
                new Product(3,"Java","Damascus",11.2,new List<string>(){"brown","yallow","red"}),
                new Product(4,"Sql","Sham",10,new List<string>(){"red","blue","green"}),
                new Product(5,"Python","Hama",15.5,new List<string>(){"red","blue","green"}),
                new Product(6,"Oracle","Hama",14.5,new List<string>(){"red","blue","green"}),
                new Product(7,"Php","Azaz",11,new List<string>(){"red","blue","green"}),
                new Product(8,"Java script","afrin",0.5,new List<string>(){"red","blue","green"}),
                new Product(9,"Html","afrin",4,new List<string>(){"red","blue","green"}),
                new Product(1,"Css","afrin",3,new List<string>(){"red","blue","green"}),

            };
        }
    }
}