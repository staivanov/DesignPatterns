namespace Singleton
{
    public sealed class SingletonNaive
    {
        private static SingletonNaive? _instance;


        private SingletonNaive() { }


        public static SingletonNaive Instance => _instance ??= new SingletonNaive();
    }
}
