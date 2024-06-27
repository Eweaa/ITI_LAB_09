namespace Lab_9_CL
{
    public class Utilities
    {
        static public void Swap<T>(ref T T1, ref T T2)
        {
            T temp = T2;
            T2 = T1;
            T1 = temp;
        }
    }

    public class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x; Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(object? obj)
        {
            Point p = obj as Point;
            if (p.X > X) return -1;
            else if (p.X < X) return 1;
            else return 0;
        }
    }


    public interface ISerise
    {
        int Next();
    }

    public class EvenSeries : ISerise
    {
        int Num = 0;
        public int Next()
        {
            return Num += 2;
        }
    }

    public class OddSeries : ISerise
    {
        int Num = 1;
        public int Next()
        {
            return Num += 2;
        }
    }

    public class FibonacciSeries : ISerise
    {
        int current = 0;
        int prev = 0;
        public int Next()
        {
            if (current == 0)
            {
                current = 1;
                return current;
            }

            int nextNum = current + prev;
            prev = current;
            current = nextNum;


            return nextNum;
        }
    }

    public class SeriesEngine
    {
        public void PrintNextNumber(ISerise o)
        {
            Console.WriteLine(o.Next());
        }
    }

}
