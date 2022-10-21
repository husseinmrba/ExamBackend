namespace Inheritance
{
    public class Student : Person
    {
        public Student()
        {
            Console.WriteLine("In Student");

        }
        public Student(int x, int y) : base(y)
        {
            Console.WriteLine($"In Student {x}");
        }
        public double Score { get; set; }

        //new public void print()
        //{
        //    Console.WriteLine("Hello student");
        //}
        public override void print()
        {
            Console.WriteLine("Hello student");
        }

        public override string ToString()
        {
            return "instance to string";
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}