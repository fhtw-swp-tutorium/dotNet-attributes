using System;

namespace DotNetAttributes.Observer
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NotifyObserversAttribute : Attribute
    {
         
    }
}