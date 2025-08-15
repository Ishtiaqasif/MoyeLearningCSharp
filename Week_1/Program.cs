namespace Week_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string? input = Console.ReadLine();

            //int inputNumber = int.Parse(input);

            int res = MoyesString.CharCount(input);

            Console.WriteLine(res);
        }
    }
}