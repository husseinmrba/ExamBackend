namespace Inheritance
{
    public class Person
    {
        public Person()
        {
            Console.WriteLine("In Person");
        }
        public Person(int y)
        {
            Console.WriteLine($"In Person {y}");
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public void print()
        //{
        //    Console.WriteLine("Hello person");
        //}
        public virtual void print()
        {
            Console.WriteLine("Hello person");
        }
    }
}