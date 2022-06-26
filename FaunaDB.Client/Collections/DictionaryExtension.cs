using System.Collections.Generic;
using System.Linq;

namespace FaunaDB.Collections
{
    internal static class DictionaryExtension
    {
        public static bool DictEquals<TKey, TValue>(this IReadOnlyDictionary<TKey, TValue> a, IReadOnlyDictionary<TKey, TValue> b)
        {
            if (a.Count != b.Count)
            {
                return false;
            }

            foreach (var kv in a)
            {
                if (!b.TryGetValue(kv.Key, out var valueB))
                {
                    return false;
                }

                if (!Equals(kv.Value, valueB))
                {
                    return false;
                }
            }

            return true;
        }

        public static Dictionary<TKey, TValue> FilterNulls<TKey, TValue>(this Dictionary<TKey, TValue> dict)
        {
#if !NETSTANDARD2_1
            return dict.Where(kv => kv.Value != null)
                .ToDictionary(kv => kv.Key, kv => kv.Value, dict.Comparer);
#else
            return new Dictionary<TKey, TValue>(dict.Where(kv => kv.Value != null), dict.Comparer);
#endif
        }
    }
}