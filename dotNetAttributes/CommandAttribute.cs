using System;

namespace DotNetAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InvokerAttribute : Attribute
    {
        public InvokerAttribute()
        {
        }

        public InvokerAttribute(Type factory)
        {
            Factory = factory;
        }

        public Type Factory { get; private set; }

    }

    [AttributeUsage(AttributeTargets.Method)]
    public class InvokeCommandAttribute : Attribute { }
}