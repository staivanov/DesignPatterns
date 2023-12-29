using Singleton;

namespace DesignPatterns
{
    public class Program
    {
        static void Main()
        {
            SingletonNaive singleton = SingletonNaive.Instance;
        }
    }
}
