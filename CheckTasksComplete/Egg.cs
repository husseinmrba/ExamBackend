using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTasksComplete
{
    internal class Egg
    {
        public static async Task<Egg> StartEggAsync()
        {
            Console.WriteLine("Starting Egg");
            await Task.Delay(7000);
            Console.WriteLine("Enging Egg");
            return new Egg();
        }
    }
}
