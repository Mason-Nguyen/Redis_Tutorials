namespace Redis_Tutorials
{
    using Redis_Tutorials.BasicCache;
    using Redis_Tutorials.Helper;
    using Redis_Tutorials.Pipeline_Mutiplexers;
    using Redis_Tutorials.RedisPubSub;
    using StackExchange.Redis;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            // Basic usage
            //BasicCaching.SaveData();
            //BasicCaching.ReadData();

            // Pipeline & Multiplexers
            //await RedisConcurency.SaveDataAsync();
            //await RedisConcurency.ReadDataAsync();

            // Pub/Sub
            Publisher.PublishMessageToChannelPattern();
            Subcriber.SubscribeMessageWithChannelPattern();

            Console.ReadKey();
        }
    }
}
