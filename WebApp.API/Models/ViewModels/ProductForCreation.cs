using System.ComponentModel.DataAnnotations;

namespace WebApp.API.Models.ViewModels
{
    public class ProductForCreation
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
