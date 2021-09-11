using ObserverPattern.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class VideoData
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
            VideoDataChanged();
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
            VideoDataChanged();
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void SetFileName(string value)
        {
            fileName = value;
            VideoDataChanged();
        }

        private readonly EmailNotifier _emailNotifier;
        private readonly YoutubeNotifier _youtubeNotifier;
        private readonly PhoneNotifier _phoneNotifier;

        public VideoData()
        {
            _emailNotifier = new EmailNotifier();
            _youtubeNotifier = new YoutubeNotifier();
            _phoneNotifier = new PhoneNotifier();
        }

        public void VideoDataChanged()
        {
            var title = GetTitle();
            var description = GetDescription();
            var fileName = GetFileName();

            _emailNotifier.Notify(title, description, fileName);
            _youtubeNotifier.Notify(title, description, fileName);
            _phoneNotifier.Notify(title, description, fileName);
        }
    }
}