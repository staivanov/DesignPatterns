using NullObject.Interface;

namespace NullObject.Entities
{
    public class NullPerson : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }

        public NullPerson()
        {
            FirstName = "Jack";
            LastName = "Sparrow";
        }


        public override string ToString()
        {
            string fullName = $"{FirstName} {LastName}";
            return fullName;
        }
    }
}
