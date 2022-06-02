namespace Indexers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "John";
            Console.WriteLine(cookie["name"]);
        }
    }
}