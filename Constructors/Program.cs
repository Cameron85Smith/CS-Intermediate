namespace Constructors
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1, "John");
            var order = new Order();
            customer.Orders.Add(order);
            
            // Note: IL (Intermediate Language) will automatically
            // create a default constructor (parameterless) for us
            // if there are no overloads in the class.
            Console.WriteLine(customer.Id); // 0
            Console.WriteLine(customer.Name); // NULL
        }
    }
}