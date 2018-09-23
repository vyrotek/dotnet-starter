using System;
using System.Collections.Generic;
using System.Linq;

namespace Starter.Core.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> Batch<T>(this IEnumerable<T> list, int size)
        {
            if (size <= 0)
                throw new ArgumentException("Size must be greater than 0.");

            while (list.Any())
            {
                yield return list.Take(size);
                list = list.Skip(size);
            }
        }
    }
}
