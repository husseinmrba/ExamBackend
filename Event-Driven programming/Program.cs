namespace Event_Driven_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += Timer_AddPerson;
            timer.Start();


            Console.ReadLine();
        }

        private static void Timer_AddPerson(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello, world {0}",e.SignalTime);
        }
    }
}