namespace Lab2_sharps
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ColoredPoint obj = new ColoredPoint(2, 3, "black");
            ColoredLine obj1 = new ColoredLine(1, 2, 3, 4, "red");
            Line obj2 = new Line(1, 2, 3, 4);
            PolyLine obj3 = new PolyLine(1, 2, 3, 4, 5, 6, 7, 8);
        }
    }
}