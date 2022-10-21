namespace Interface
{
    internal partial class Program
    {
        public class CSharp : IPrint
        {
            public void print()
            {
                Console.WriteLine("print C#");
            }
        }
    }
}