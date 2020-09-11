using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("sending mail...");
        }
    }
}