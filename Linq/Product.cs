namespace Linq
{
    internal class Product
    {
        public Product(int id, string name, string city, double price, List<string> colors)
        {
            Id = id;
            Name = name;
            City = city;
            Price = price;
            Colors = colors;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Price { get; set; }
        public List<string> Colors { get; set; } = new List<string>();

    }
}