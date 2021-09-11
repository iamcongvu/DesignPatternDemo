using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Services
{
    public interface INotify
    {
        void Notify(string title, string description, string fileName);
    }
}