using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTasksComplete
{
    internal class Toast
    {

        public static async Task<Toast> StartToastAsync()
        {
            Console.WriteLine("Starting Toast");
            await Task.Delay(5000);
            Console.WriteLine("Enging Toast");
            return new Toast();
        }
    }
}
