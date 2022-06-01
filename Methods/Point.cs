namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // We can pass values for an x and y.
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Or we can pass a Point object.
        public void Move(Point newLocation)
        {
            // Defensive programming improves
            // the robustness of your code.
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y);
        }
    }
}