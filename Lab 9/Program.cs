using Lab_9_CL;
namespace Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new(10, 20);
            Point p2 = new(50, 20);
            Point p3 = new(5, 20);
            Point p4 = new(3, 20);
            Point[] arr = [p1, p2, p3, p4];
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            int x = 5;
            int y = 50;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Utilities.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            EvenSeries e = new EvenSeries();
            SeriesEngine engine = new SeriesEngine();
            OddSeries o = new OddSeries();
            engine.PrintNextNumber(e);
            engine.PrintNextNumber(e);
            engine.PrintNextNumber(e);
            Console.WriteLine("----------------");
            engine.PrintNextNumber(o);
            engine.PrintNextNumber(o);
            engine.PrintNextNumber(o);
            Console.WriteLine("----------------");
            FibonacciSeries f = new FibonacciSeries();
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
            engine.PrintNextNumber(f);
        }
    }
}
