namespace Properties
{
    public class Person
    {
        // Auto-Implemented Property: The compiler automatically
        // creates a private field for BirthDate. 
        public DateTime BirthDate { get; private set; }

        // If we need to set the BirthDate once, we set the
        // BirthDate setter to private. Then we need to set
        // the BirthDate in the constructor.
        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }

        // We cannot create an Auto-Implemented property on Age
        // because Age requires logic.
        public int Age
        {
            get
            { 
                var timespan = DateTime.Today - BirthDate; 
                var years = timespan.Days/365;

                return years;
            }
        }
    }
}