using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending SMS...");
        }
    }
}