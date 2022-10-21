using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTasksComplete
{
    internal class Coffee
    {
        public static async Task<Coffee> StartCoffeAsync()
        {
            Console.WriteLine("Starting Coffee");
            await Task.Delay(2000);
            Console.WriteLine("Enging Coffee");
            return new Coffee();
        }
    }
}
