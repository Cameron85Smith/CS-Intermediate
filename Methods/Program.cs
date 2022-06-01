namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            UseParams();
            UsePoints();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine($"Passing variables: {calculator.Add(1, 2, 3, 4)}");
            Console.WriteLine($"Passing an Array: {calculator.Add(new int[] { 1, 2, 3, 4, 5 })}");
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(30, 40)); // Using a Point object.
                Console.WriteLine($"X: {point.X}\nY: {point.Y}");

                point.Move(100, 200); // Using variables.
                Console.WriteLine($"X: {point.X}\nY: {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }
    }
}