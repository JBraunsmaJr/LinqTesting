using System;
using System.Collections.Generic;

namespace LinqTesting.Extensions
{
    public static class LinqExtensions
    {
        public static bool CustomAny<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));
            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));
            
            foreach(var item in source)
                if (predicate(item))
                    return true;

            return false;
        }

        public static T CustomFirstOrDefault<T>(this T[] source, Func<T, bool> predicate)
        {
            if (source is null)
                throw new ArgumentNullException(nameof(source));

            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));
            
            foreach(var item in source)
                if (predicate(item))
                    return item;
            return default;
        }
    }
}