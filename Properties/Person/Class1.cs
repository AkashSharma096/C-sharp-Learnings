public class Person
{
    private int _personAge;


    public int PersonAge
    {
        get { return _personAge; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative.");
            }
            _personAge = value;
        }
    }
}