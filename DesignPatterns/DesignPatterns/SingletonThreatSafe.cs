namespace Singleton
{
    public sealed class SingletonThreatSafe
    {
        private static SingletonThreatSafe? _instance = null;
        private static readonly object padlock = new object();


        private SingletonThreatSafe() { }


        public SingletonThreatSafe Instance
        {
            get
            {
                if(_instance is null) //Locked only if a instance is null.
                {
                    lock (padlock)
                    {
                        if(_instance is null)
                        {
                            return _instance = new SingletonThreatSafe();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
