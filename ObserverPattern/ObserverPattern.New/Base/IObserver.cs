using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.New.Base
{
    public abstract class Observer
    {
        protected Subject Subject;

        public abstract void Notify(object arg);
    }
}