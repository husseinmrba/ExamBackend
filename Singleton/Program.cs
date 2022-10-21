namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Single.GetInstanse.nums.Add(9);
            Console.WriteLine(Single.GetInstanse.nums.Sum());
            var x = Single.GetInstanse.nums;
            x.Add(10);
            Console.WriteLine(Single.GetInstanse.nums.Sum());

        }
    }
}