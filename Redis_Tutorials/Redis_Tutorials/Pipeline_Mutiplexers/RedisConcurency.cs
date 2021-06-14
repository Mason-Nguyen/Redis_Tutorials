using Redis_Tutorials.Helper;
using StackExchange.Redis;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Redis_Tutorials.Pipeline_Mutiplexers
{
    public class RedisConcurency
    {
        public static async Task ReadDataAsync()
        {
            var database = RedisConnectionHelper.GetRedisDatabase();
            var devicesCount = 100;
            Console.WriteLine("Reading data from cache");

            var tasks = Enumerable.Range(0, devicesCount).Select(c => GetStringAsync(database, c));
            await Task.WhenAll(tasks);

            Console.WriteLine("Reading data from cache - END");
        }

        private static async Task GetStringAsync(IDatabase database, int count)
        {
            var value = await database.StringGetAsync($"Device_Status:{count}");
            Console.WriteLine($"Valor={value}");
        }

        public static async Task SaveDataAsync()
        {
            var devicesCount = 100;
            var database = RedisConnectionHelper.GetRedisDatabase();
            Console.WriteLine("Saving random data in cache");

            var tasks = Enumerable.Range(0, devicesCount).Select(c => database.StringSetAsync($"Device_Status:{c}", c));
            await Task.WhenAll(tasks);

            Console.WriteLine("Saving random data in cache - END");
        }
    }
}
