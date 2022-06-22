namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // With inheritance, we can use properties
            // from the parent class
            var text = new Text();
            text.Width = 100;
            text.Copy(); // From the parent class
        }
    }
}