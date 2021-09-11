using System;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var videoData = new VideoData();

            videoData.SetTitle("Observer Design Pattern: Analyze");

            Console.WriteLine("\nUpdate video data!\n");

            videoData.SetDescription("New Desciption");
        }
    }
}