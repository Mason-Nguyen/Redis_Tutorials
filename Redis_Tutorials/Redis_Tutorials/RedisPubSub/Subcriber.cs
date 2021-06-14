using Redis_Tutorials.Helper;
using StackExchange.Redis;
using System;

namespace Redis_Tutorials.RedisPubSub
{
    public class Subcriber
    {
        public static void SubscribeMessageFromChannel()
        {
            const string channel = "Channel";

            var subscriber = RedisConnectionHelper.Connection.GetSubscriber();
            Console.WriteLine("Start subcribe message...");
            subscriber.Subscribe(channel, (channel, message) =>
            {
                Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}<Normal - {channel}><{message}>.");
            });
        }

        public static void SubscribeMessageWithChannelPattern()
        {
            const string channelPattern = "Channel.*";

            var subscriber = RedisConnectionHelper.Connection.GetSubscriber();
            var subPatternChannel = new RedisChannel(channelPattern, RedisChannel.PatternMode.Pattern);
            Console.WriteLine("Start subcribe message...");
            subscriber.Subscribe(subPatternChannel, (channel, message) =>
            {
                Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")}<Pattern - {channel}><{message}>.");
            });
        }
    }
}
