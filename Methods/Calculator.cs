namespace Methods
{
    public class Calculator
    {
        // We add the params keyword to
        // accept a varying amount of variables.
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
                sum += number;

            return sum;
        }
    }
}