using System;

namespace DotNetAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SingletonAttribute : Attribute { }
}