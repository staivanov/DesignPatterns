namespace ChainOfResponsibility
{
    public class UserValidationException : Exception
    {
        public string Text { get; set; }

        public UserValidationException(string text)
        {
            Text = text;
        }
    }
}
