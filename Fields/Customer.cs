namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;

        // If we know that this field should be initialized only once,
        // we use a readonly modifier on the field. A readonly field
        // can only be initialized when declaring the field, or in the
        // constructor.
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;   
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
        }
    }
}