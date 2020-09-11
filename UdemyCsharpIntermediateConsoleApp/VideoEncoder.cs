using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    //as developers, we want to reduce the impact of change
    //Open Closed Principle: Entities should be open for extension, but closed for modification
    //the following refactored code allows us to create new implementations of the INotificationChannel interface w/out changing the VideoEncoder class
    //i.e. refactored to use OPC
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //video encoding logic here
            //...

            foreach (var channel in _notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}