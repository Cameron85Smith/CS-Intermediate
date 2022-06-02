using System;
namespace Properties
{

    class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person(new DateTime(1985, 09, 28));
            Console.WriteLine(person.Age);
        }
    }
}