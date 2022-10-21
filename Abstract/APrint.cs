namespace Abstract
{
    public abstract class APrint
        {
            public virtual void Print()
            {
                Console.WriteLine("print from inside APrint");
            }
            public abstract void PrintAbstract();
        }
}