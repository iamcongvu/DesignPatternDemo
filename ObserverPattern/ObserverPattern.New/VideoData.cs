using ObserverPattern.New.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.New
{
    public class VideoData : Subject
    {
        private string title;
        private string description;
        private string fileName;

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void SetFileName(string value)
        {
            fileName = value;
        }

        public void VideoDataChanged()
        {
            NotifyObservers(null);
        }
    }
}