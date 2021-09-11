using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Services
{
    public class PhoneNotifier : INotify
    {
        public void Notify(string title, string description, string fileName)
        {
            Console.WriteLine(string.Format($"Notify all subcribers via YOUTUBE with new data " +
                $"\n\tName={title}" + $"\n\tDescription={description}" +
                $"\n\tFileName={fileName}"));
        }
    }
}