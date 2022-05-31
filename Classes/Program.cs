namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, my name is {Name}");
        }

        // Parse a string to a Person object.
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // A static member is only accessible from a class, and not an object.
            var person = Person.Parse("Mary");
            person.Introduce("Scott");
        }
    }
}