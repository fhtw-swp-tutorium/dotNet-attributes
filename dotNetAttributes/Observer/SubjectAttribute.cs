using System;

namespace DotNetAttributes.Observer
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SubjectAttribute : Attribute, IFactoryAttribute
    {
        public SubjectAttribute() { }

        public SubjectAttribute(Type factory)
        {
            Factory = factory;
        }

        public Type Factory { get; private set; }
    }
}