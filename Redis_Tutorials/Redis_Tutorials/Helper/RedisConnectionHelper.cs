namespace Redis_Tutorials.Helper
{
    using StackExchange.Redis;
    using System;

    public class RedisConnectionHelper
    {
        static RedisConnectionHelper()
        {
            lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect("localhost");
            });
        }

        private readonly static Lazy<ConnectionMultiplexer> lazyConnection;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }

        public static IDatabase GetRedisDatabase() => Connection.GetDatabase();
    }
}
