using NullObject.Entities;
using NullObject.View;

namespace NullObject
{
    public class Program
    {
        public static void Main()
        {
            Person person = new("George", "Michael");
            PersonView personView = new(null);
            PersonView personViewTwo = new(person);
        }
    }
}
