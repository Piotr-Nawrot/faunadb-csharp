using System;
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
            if (v0 == null)
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
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2)
        {
            var dict = new Dictionary<TKey, TValue>(3);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3)
        {
            var dict = new Dictionary<TKey, TValue>(4);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4)
        {
            var dict = new Dictionary<TKey, TValue>(5);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4, TKey k5, TValue v5)
        {
            var dict = new Dictionary<TKey, TValue>(6);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            if (v5 != null)
            {
                dict.Add(k5, v5);
            }

            return dict;
        }

        public static IReadOnlyDictionary<TKey, TValue> Of<TKey, TValue>(TKey k0, TValue v0, TKey k1, TValue v1, TKey k2, TValue v2, TKey k3, TValue v3, TKey k4, TValue v4, TKey k5, TValue v5, TKey k6, TValue v6)
        {
            var dict = new Dictionary<TKey, TValue>(7);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            if (v5 != null)
            {
                dict.Add(k5, v5);
            }

            if (v6 != null)
            {
                dict.Add(k6, v6);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0)
        {
            if (v0 == null)
            {
                return new Dictionary<string, TValue>(0, StringComparer.Ordinal);
            }

            return new Dictionary<string, TValue>(1, StringComparer.Ordinal)
            {
                { k0, v0 },
            };
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1)
        {
            var dict = new Dictionary<string, TValue>(2, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1, string k2, TValue v2)
        {
            var dict = new Dictionary<string, TValue>(3, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1, string k2, TValue v2, string k3, TValue v3)
        {
            var dict = new Dictionary<string, TValue>(4, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1, string k2, TValue v2, string k3, TValue v3, string k4, TValue v4)
        {
            var dict = new Dictionary<string, TValue>(5, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1, string k2, TValue v2, string k3, TValue v3, string k4, TValue v4, string k5, TValue v5)
        {
            var dict = new Dictionary<string, TValue>(6, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            if (v5 != null)
            {
                dict.Add(k5, v5);
            }

            return dict;
        }

        public static IReadOnlyDictionary<string, TValue> Of<TValue>(string k0, TValue v0, string k1, TValue v1, string k2, TValue v2, string k3, TValue v3, string k4, TValue v4, string k5, TValue v5, string k6, TValue v6)
        {
            var dict = new Dictionary<string, TValue>(7, StringComparer.Ordinal);
            if (v0 != null)
            {
                dict.Add(k0, v0);
            }

            if (v1 != null)
            {
                dict.Add(k1, v1);
            }

            if (v2 != null)
            {
                dict.Add(k2, v2);
            }

            if (v3 != null)
            {
                dict.Add(k3, v3);
            }

            if (v4 != null)
            {
                dict.Add(k4, v4);
            }

            if (v5 != null)
            {
                dict.Add(k5, v5);
            }

            if (v6 != null)
            {
                dict.Add(k6, v6);
            }

            return dict;
        }
    }
}
