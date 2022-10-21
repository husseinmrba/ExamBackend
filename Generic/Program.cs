using Microsoft.VisualBasic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic fun
            bool v = equals<int>(1, 1);
            // Generic class
            Person<Student> person = new Person<Student>();
            // convert from T type to double
            var s = sum<string>("44", "6");
            // convert from int to T type
            var rr = compare<int>(1, 2);

        }
        class Student : ITest
        {
            // new()
            public Student()
            {

            }
        }
        class Person<T> where T : class , ITest , new()
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public T Value { get; set; }
        }
        public static bool equals<T>(T x, T y)
        {
            return (x.Equals(y));
        }
        public static double sum<T>(T x, T y)
        {
            double xx = (double)Convert.ChangeType(x, typeof(double));
            double yy = (double)Convert.ChangeType(y, typeof(double));

            return xx + yy;
        }
        public static T compare<T>(T x, T y)
        {
            int r = 55;
            T rr = (T) Convert.ChangeType(r, typeof(T));
            return rr;
        }
    }
}