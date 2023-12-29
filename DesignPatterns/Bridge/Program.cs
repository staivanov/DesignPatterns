using Bridge.Licenses;

namespace Bridge
{
    public class Program
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;
            Concert motleyCrue = new("Motley Crue");
            Concert deepPurple = new("Deep Purple");

            ThreeDaysLicense threeDaysLicense = new(motleyCrue, new DateTime(2023, 12, 15)); ;
            LifeLongLicense lifeLongLicense = new(deepPurple, new DateTime(2023, 12, 29));


            PrintLicenseDetails(threeDaysLicense);
            Console.WriteLine();
            PrintLicenseDetails(lifeLongLicense);
        }


        private static void PrintLicenseDetails(ConcertLicense license)
        {
            Console.WriteLine($"Brand name: {license.Concert.BandName}");
            Console.WriteLine($"Price: {license.GetPrice()}");
            Console.WriteLine($"Licens: {GetValidFor(license)}");
        }


        private static string GetValidFor(ConcertLicense license)
        {
            DateTime? expirationDate = license.GetExpirationDate();

            if (expirationDate == null)
                return "Forever";

            TimeSpan? timeSpan = expirationDate.Value - DateTime.Now;
            string expirationTimeSpan = $"{timeSpan.Value.Days}d {timeSpan.Value.Hours}h {timeSpan.Value.Minutes}m";

            return expirationTimeSpan;

        }
    }
}
