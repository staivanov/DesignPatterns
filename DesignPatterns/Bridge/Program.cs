using Bridge.Discounts;
using Bridge.Licenses;
using static System.Console;

namespace Bridge
{
    public class Program
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;

            List<Concert> concerts = new()
            {
                new("Motley Crue"),
                new("Deep Purple"),
                new("Led Zeppelin"),
                new("KiSS"),
                new("Foreign")
             };

            NoDiscount noDiscount = new();
            InvalidDiscount invalidDiscount = new();
            SeniorDiscount seniorDiscount = new();

            ThreeDaysLicense threeDaysLicense = new(concerts[0], now, noDiscount);
            LifeLongLicense lifeLongLicense = new(concerts[1], now, noDiscount);
            ThreeDaysLicense threeDaysLicenseTwo = new(concerts[2], now, invalidDiscount);
            LifeLongLicense lifeLongLicenseTwo = new(concerts[3], now, seniorDiscount);


            PrintLicenseDetails(threeDaysLicense);
            WriteLine();
            PrintLicenseDetails(lifeLongLicense);
            WriteLine();
            PrintLicenseDetails(threeDaysLicenseTwo);
            WriteLine();
            PrintLicenseDetails(lifeLongLicenseTwo);
        }


        private static void PrintLicenseDetails(ConcertLicense license)
        {
            WriteLine($"Brand name: {license.Concert.BandName}");
            WriteLine($"Price: {license.GetPrice()}");
            WriteLine($"Licens: {GetValidFor(license)}");
        }


        private static string GetValidFor(ConcertLicense license)
        {
            DateTime? expirationDate = license.GetExpirationDate();

            if (expirationDate == null)
            {
                return "Forever";
            }

            TimeSpan? timeSpan = expirationDate.Value - DateTime.Now;
            string expirationTimeSpan = $"{timeSpan.Value.Days}d {timeSpan.Value.Hours}h {timeSpan.Value.Minutes}m";

            return expirationTimeSpan;
        }
    }
}
