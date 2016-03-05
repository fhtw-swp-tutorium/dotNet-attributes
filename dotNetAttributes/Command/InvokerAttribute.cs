using System;

namespace DotNetAttributes.Command
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InvokerAttribute : Attribute, IFactoryAttribute
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
}