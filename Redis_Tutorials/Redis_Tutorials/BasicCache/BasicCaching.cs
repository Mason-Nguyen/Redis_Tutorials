namespace Redis_Tutorials.BasicCache
{
    using Redis_Tutorials.Helper;
    using System;

    public class BasicCaching
    {
        public static void ReadData()
        {
            var database = RedisConnectionHelper.GetRedisDatabase();
            var devicesCount = 5;
            Console.WriteLine("Reading data from cache");
            for (int i = 0; i < devicesCount; i++)
            {
                var value = database.StringGet($"Device_Status:{i}");
                Console.WriteLine($"Valor={value}");
            }
            Console.WriteLine("Reading data from cache - END");
        }

        public static void SaveData()
        {
            var devicesCount = 5;
            var database = RedisConnectionHelper.GetRedisDatabase();
            Console.WriteLine("Saving random data in cache");
            for (int i = 0; i < devicesCount; i++)
            {
                database.StringSet($"Device_Status:{i}", i);
            }
            Console.WriteLine("Saving random data in cache - END");
        }
    }
}
