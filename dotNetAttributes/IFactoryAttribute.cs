using System;

namespace DotNetAttributes
{
    public interface IFactoryAttribute
    {
        Type Factory { get; }
    }
}