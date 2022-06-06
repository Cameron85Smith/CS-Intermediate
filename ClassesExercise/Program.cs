namespace ClassesExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            //(1) Design a Stopwatch - See Stopwatch class for more detail.
            Stopwatch();

            // (2) Design a class called Post. See Post class for more detail.
            StackOverflow();
        }

        private static void Stopwatch()
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Please press enter to start the timer");
            Console.ReadLine();
            Console.WriteLine("Start " + stopwatch.Start(DateTime.Now));
            Console.WriteLine();
            Console.WriteLine("Please press enter to stop the timer");
            Console.ReadLine();
            Console.WriteLine("Stop " + stopwatch.Stop(DateTime.Now));

            Console.WriteLine();
            Console.WriteLine("Duration " + stopwatch.Duration);
        }

        private static void StackOverflow()
        {
            var title = "Stack OverFlow Post";
            var description = "How many votes after up and down votes example";

            // Object Initialization syntax.
            var post = new Post(title, description);

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Title: {post.title}");
            Console.WriteLine($"Description: {post.description}");
            Console.WriteLine($"Number of votes: {post.votes}");
            Console.WriteLine(post.creationDate);
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}