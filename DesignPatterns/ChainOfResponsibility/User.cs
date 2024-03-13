namespace ChainOfResponsibility
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EGN { get; set; }
        public Enum MainTown { get; set; }


        public User(
            int id,
            string firstName,
            string lastName,
            int egn,
            Enum mainTown)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EGN = egn;
            MainTown = mainTown;
        }
    }
}
