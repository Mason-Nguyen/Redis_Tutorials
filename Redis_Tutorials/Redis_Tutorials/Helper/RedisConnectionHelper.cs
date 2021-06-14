namespace Redis_Tutorials.Helper
{
    using StackExchange.Redis;
    using System;

    public sealed class RedisConnectionHelper
    {
        private RedisConnectionHelper()
        {
        }

        private readonly static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            return ConnectionMultiplexer.Connect("localhost:6379");
        });

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
