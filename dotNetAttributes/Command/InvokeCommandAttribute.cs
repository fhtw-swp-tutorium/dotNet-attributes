using System;

namespace DotNetAttributes.Command
{
    [AttributeUsage(AttributeTargets.Method)]
    public class InvokeCommandAttribute : Attribute { }
}