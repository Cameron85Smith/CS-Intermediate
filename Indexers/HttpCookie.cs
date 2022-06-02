namespace Indexers
{
    // If you are working with a class that has the semantic of a
    // collection (list, or a dictionary), you can improve your code
    // by declaring an indexer. An indexer is an easier way to access
    // elements in a collection as opposed to creating a method that
    // sets and gets a value.
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        private DateTime _expiry { get; set; }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        } 
    }
}