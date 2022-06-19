using System.Collections.Generic;

namespace FaunaDB.Collections
{
    internal static class ImmutableDictionary
    {
        public static IReadOnlyDictionary<TKey, TValue> Empty<TKey, TValue>() =>
            new Dictionary<TKey, TValue>();

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(Dictionary<TKey, TValue> dict) =>
            dict?.FilterNulls();

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0)
        {
            if (k0 == null)
            {
                return new Dictionary<TKey, TValue>(0);
            }

            return new Dictionary<TKey, TValue>(1)
            {
                { k0, v0 },
            };
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1)
        {
            var dict = new Dictionary<TKey, TValue>(2);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2)
        {
            var dict = new Dictionary<TKey, TValue>(3);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

            if (k2 != null)
            {
                dict[k2] = v2;
            }

#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3)
        {
            var dict = new Dictionary<TKey, TValue>(4);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

            if (k2 != null)
            {
                dict[k2] = v2;
            }

            if (k3 != null)
            {
                dict[k3] = v3;
            }

#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4)
        {
            var dict = new Dictionary<TKey, TValue>(5);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

            if (k2 != null)
            {
                dict[k2] = v2;
            }

            if (k3 != null)
            {
                dict[k3] = v3;
            }

            if (k4 != null)
            {
                dict[k4] = v4;
            }
#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4, TKey k5, TValue v5)
        {
            var dict = new Dictionary<TKey, TValue>(6);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

            if (k2 != null)
            {
                dict[k2] = v2;
            }

            if (k3 != null)
            {
                dict[k3] = v3;
            }

            if (k4 != null)
            {
                dict[k4] = v4;
            }

            if (k5 != null)
            {
                dict[k5] = v5;
            }

#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4, TKey k5, TValue v5, TKey k6, TValue v6)
        {
            var dict = new Dictionary<TKey, TValue>(7);
            if (k0 != null)
            {
                dict[k0] = v0;
            }

            if (k1 != null)
            {
                dict[k1] = v1;
            }

            if (k2 != null)
            {
                dict[k2] = v2;
            }

            if (k3 != null)
            {
                dict[k3] = v3;
            }

            if (k4 != null)
            {
                dict[k4] = v4;
            }

            if (k5 != null)
            {
                dict[k5] = v5;
            }

            if (k6 != null)
            {
                dict[k6] = v6;
            }

#if NETSTANDARD2_1
            dict.TrimExcess();
#endif
            return dict;
        }
    }
}
