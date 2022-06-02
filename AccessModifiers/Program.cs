namespace AccessModifiers
{
    // You have two methods that changes the value of _birthdate,
    // but why can't we go directly to the _birthdate field and
    // make the change? Ans: Objects are about behaviour. The
    // fields are primarily their internals, the implementation
    // detail; which should be hidden from the outside world. From
    // an Object Oriented perspective we want to follow the principle
    // of Encapsulation; which suggests that objects should hide
    // their implementation detail and reveal what they can do,
    // instead of how they do what they are supposed to do.
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthDate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthDate;
        }
    }

    class Program
    {

        public static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1985, 12, 25));
            Console.WriteLine(person.GetBirthdate());  
        }
    }
}