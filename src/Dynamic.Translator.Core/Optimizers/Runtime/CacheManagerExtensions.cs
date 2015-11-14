﻿namespace Dynamic.Translator.Core.Optimizers.Runtime
{
    public static class CacheManagerExtensions
    {
        public static ITypedCache<TKey, TValue> GetCacheEnvironment<TKey, TValue>(this ICacheManager cacheManager, string name)
        {
            return cacheManager.GetCacheEnvironment(name).AsTyped<TKey, TValue>();
        }
    }
}