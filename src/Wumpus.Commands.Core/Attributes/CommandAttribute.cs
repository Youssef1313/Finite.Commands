using System;

namespace Wumpus.Commands
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true,
        AllowMultiple = false)]
    public sealed class CommandAttribute : Attribute
    {
        public string[] Aliases { get; }

        public CommandAttribute(params string[] aliases)
        {
            Aliases = aliases;
        }
    }
}
