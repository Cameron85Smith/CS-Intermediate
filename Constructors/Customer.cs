namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>(); // Always initialize a list to empty. 
        }

        public Customer(int id)
            : this() // We get the initalized list from the previous constructor.
        {
            this.Id = id;   
        }

        public Customer(int id, string name)
            : this(id) // We get the initalized id from the previous constructor.
        {
            this.Name = name;
        }
    }
}