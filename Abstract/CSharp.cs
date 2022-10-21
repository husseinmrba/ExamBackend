namespace Abstract
{
    public class CSharp : APrint
    {
        public int Id { get; set; }
        public override void PrintAbstract()
        {
            Console.WriteLine("print from inside CSharp");
        }
    }
}