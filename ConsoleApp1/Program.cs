namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Shape shape = new Shape(3,5);

            Console.WriteLine(shape);
            Console.WriteLine($"Area = {shape.Area()}");

            #endregion


            #region Q2

            Cube cube = new Cube(2,3,4);

            cube.Print();
            Console.WriteLine($"Area =  {cube.Area()}");

            #endregion



        }
    }
}
