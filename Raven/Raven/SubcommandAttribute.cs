using System;

namespace Raven
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    public sealed class SubcommandAttribute : Attribute
    {
        public string Name { get; }
        public string Usage { get; }
        public string Description { get; }

        public SubcommandAttribute(string name, string usage, string description)
        {
            Name = !String.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException("Parameter name is null or empty");
            Usage = usage ?? throw new ArgumentException("Parameter usage is null");
            Description = description ?? throw new ArgumentException("Parameter description is null");
        }
    }
}