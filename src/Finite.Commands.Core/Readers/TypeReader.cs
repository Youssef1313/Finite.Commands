using System;

namespace Finite.Commands
{
    public abstract class TypeReader<T> : ITypeReader<T>
    {
        public Type SupportedType
            => typeof(T);

        public abstract bool TryRead(ReadOnlySpan<char> value, out T result);

        public bool TryRead(ReadOnlySpan<char> value, out object result)
        {
            var success = TryRead(value, out T realResult);
            result = realResult;
            return success;
        }
    }
}
