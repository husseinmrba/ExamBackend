namespace Interface
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Python python = new Python();
            python.Id = 1;
            CSharp cSharp = new CSharp();
            //cSharp.print();
            Python p = new Python();
            p.Id = 1;
            var equals = python.Equals(p);
            var compare = python.CompareTo(p);


            List<IPrint> list = new List<IPrint>();
            list.Add(python);
            list.Add(cSharp);
            list.Add(p);

            foreach (var item in list)
            {
                item.print();
            }
        }
    }
}