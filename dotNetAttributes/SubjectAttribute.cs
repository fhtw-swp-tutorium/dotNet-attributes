using System;

namespace DotNetAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SubjectAttribute : Attribute
    {
        public SubjectAttribute() { }

        public SubjectAttribute(Type factory)
        {
            Factory = factory;
        }

        public Type Factory { get; private set; }
    }
}