using Redis_Tutorials.Helper;
using System;

namespace Redis_Tutorials.RedisPubSub
{
    public class Publisher
    {
        public static void PublishMessageToSingleChannel()
        {
            const string channelName = "Channel";

            var publisher = RedisConnectionHelper.Connection.GetSubscriber();

            // Publish to a channel
            publisher.Publish(channelName, $"Publish a message to channel: {channelName}");

            Console.WriteLine("Publish - Done");
        }

        public static void PublishMessageToChannelPattern()
        {
            const string channelPattern = "Channel.*";

            var publisher = RedisConnectionHelper.Connection.GetSubscriber();

            // publish message to channels which match the pattern
            publisher.Publish(channelPattern, $"Publish a message to literal channel: channelPattern");

            Console.WriteLine("Publish - Done");
        }
    }
}
