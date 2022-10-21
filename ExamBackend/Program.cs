namespace ExamBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            var type = x.GetType();
            Console.WriteLine(type);

            Test test = new Test();
            var typee = test.GetType();
            Console.WriteLine($"{typee} \n {typee.Namespace}   {typee.Name}");
        }

        class Test
        {

        }
        
       
   
    }
}