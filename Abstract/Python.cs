namespace Abstract
{
    public class Python : APrint
    {
        public Python()
        {
            Console.WriteLine("print from in constructor");

        }
        ~Python()
        {
            Console.WriteLine("print from in deconstructor");
        }
        public override void PrintAbstract()
        {
            Console.WriteLine("print from inside python");
        }
    }
}