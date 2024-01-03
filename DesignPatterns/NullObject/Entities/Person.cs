using NullObject.Interface;

namespace NullObject.Entities
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public override string ToString()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName;
        }

        public static implicit operator Person(NullPerson v)
        {
            return new Person(v.FirstName, v.LastName);
        }
    }
}
