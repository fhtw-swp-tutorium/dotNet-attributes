using System;

namespace DotNetAttributes.Singleton
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SingletonAttribute : Attribute { }
}