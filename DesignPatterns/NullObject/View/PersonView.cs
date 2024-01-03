using NullObject.Entities;

namespace NullObject.View
{
    public class PersonView
    {
        private readonly Person _person;

        public PersonView(Person person)
        {
            _person = person ?? new NullPerson();
        }
    }
}
