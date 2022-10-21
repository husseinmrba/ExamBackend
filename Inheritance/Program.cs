namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //student.print();
            Person person = new Person();
            //person.print();
            Teacher teacher = new Teacher();

            List<Person> list = new List<Person>();
            list.Add(student);
            list.Add(person);
            list.Add(teacher);

            foreach (var item in list)
            {
                item.print();
            }
            
        }
    }
}