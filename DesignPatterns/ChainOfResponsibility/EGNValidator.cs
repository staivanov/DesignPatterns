namespace ChainOfResponsibility
{
    public class EGNValidator
    {
        private const short VALID_DIGITS_COUNT = 10;

        public bool Validate(int egnNumber)
        {
            bool isValid = ValidateEGNMonth(egnNumber)
                           && AreDigitsNumberValid(egnNumber);

            return isValid;
        }


        private static bool ValidateEGNMonth(int egnNumber)
        {
            bool isValidMonthSection = true;
            int numberOfMonths = 12,
                month = GetMonth(egnNumber);

            if (month > numberOfMonths)
            {
                return !isValidMonthSection;
            }
            else if (numberOfMonths == month)
            {
                return isValidMonthSection;
            }
            else
            {
                return isValidMonthSection;
            }
        }


        private static int GetMonth(int egnNumber)
        {
            string monthToString = egnNumber.ToString();
            string convertedMonth = string.Concat(monthToString.Skip(2).Take(2));
            int month = int.Parse(convertedMonth);
            return month;
        }


        private static bool AreDigitsNumberValid(int egnNumber)
            => egnNumber.ToString().Length == VALID_DIGITS_COUNT;
    }
}
