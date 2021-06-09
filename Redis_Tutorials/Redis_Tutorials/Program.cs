namespace Redis_Tutorials
{
    using Redis_Tutorials.BasicCache;
    using Redis_Tutorials.Helper;
    using StackExchange.Redis;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Basic usage
            BasicCaching.SaveData();
            BasicCaching.ReadData();

            Console.ReadKey();
        }
    }
}
