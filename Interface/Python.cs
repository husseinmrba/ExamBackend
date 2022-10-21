namespace Interface
{
    internal partial class Program
    {
        public class Python : IEquatable<Python>,IComparable<Python> ,IPrint 
        {
            public int Id { get; set; }
            public void print()
            {
                Console.WriteLine("print python");
            }

            public bool Equals(Python? other)
            {
                return this.Id == other?.Id;
            }

            public int CompareTo(Python? other)
            {
                if (this.Id == other?.Id)
                     return 0;
                return this.Id > other?.Id ? 1 : -1;
            }
        }
    }
}