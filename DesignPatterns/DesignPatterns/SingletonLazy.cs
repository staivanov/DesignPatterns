namespace Singleton
{
    public sealed class SingletonLazy
    {
        public static readonly Lazy<SingletonLazy> _instance =
            new(() => new SingletonLazy());

        private SingletonLazy() { }

        //Since it's comming from static field return value will never be null;
        public static SingletonLazy Instance { get => _instance.Value; }
    }
}
