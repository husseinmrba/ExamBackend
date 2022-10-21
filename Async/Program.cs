namespace Async
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // first use
            Console.WriteLine("Starting");
            //Task<int> x = printAsync();
            //async();
            //Console.WriteLine("Ending");
            //Console.WriteLine(x.Result);

            ///////////////////////////////////////////////////////////

            //Task<int> i = funAsync();

            Console.WriteLine("Ending Main");
            Console.ReadLine();
        }



        

        public static async Task<int> funAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("inside funAsync");
            return 5;
        }



        static async void async()
        {
            int x = await printAsync();
            Console.WriteLine(x);
        }

        public static Task<int> printAsync()
        {
            return Task.Run(() =>
            {
                Task.Delay(2000).Wait();
                Console.WriteLine("hello world");
                return 5;
            });
        }
    }

}