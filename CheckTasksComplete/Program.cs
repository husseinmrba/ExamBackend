namespace CheckTasksComplete
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("starting main");
            Task<Coffee> coffe = Coffee.StartCoffeAsync();
            Task<Egg> egg = Egg.StartEggAsync();
            Task<Toast> toast = Toast.StartToastAsync();

            List<Task> ta= new List<Task>() { coffe , egg , toast };
            while (ta.Any())
            {

                Task finished = await Task.WhenAny(ta);
                if (finished is Task<Egg> egg1)
                {
                    Console.WriteLine("Eggs is ready");
                }
                if (finished is Task<Coffee> coffee1)
                {
                    Console.WriteLine("Coffee is ready");
                }
                if (finished is Task<Toast> toast1)
                {
                    Console.WriteLine("Toast is ready");
                }
                ta.Remove(finished);
            }
            Console.WriteLine("Breakfast is ready");
            Console.WriteLine("ending main");


            Console.ReadLine();
        }
    }
}