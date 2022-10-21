namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(0, 4);
            list.Add(1);

            var index = list.IndexOf(1);
            var lastIndex = list.LastIndexOf(1);
            var count = list.Count();
            var content = list.Contains(1);
            list.Sort();
            list.Reverse();
        }
    }
}