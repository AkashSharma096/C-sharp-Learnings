namespace PersonNamespace
{
    public class Person
    {
        public string? PersonName { get; set; }
        public int Age { get; set; }

        public AgeGroupEnum AgeGroup { get; set; }
    }

    public enum AgeGroupEnum
    {
        Child,
        Teenager,
        Adult,
        Senior_Citizen
    }
}