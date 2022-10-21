namespace Inheritance
{
    public class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("In Teacher");
        }
        public override void print()
        {
            Console.WriteLine("Hello Teacher");
        }
    }
}