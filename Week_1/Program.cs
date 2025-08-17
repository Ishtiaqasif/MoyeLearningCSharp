namespace Week_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float input = float.Parse(Console.ReadLine());
            var (a, p, d) = MoyesGeometry.SquareAreaPerimeterDiagonal(input);

            Console.WriteLine($"area: {a} perimeter: {p} diagonal: {d}");
        }
    }
}