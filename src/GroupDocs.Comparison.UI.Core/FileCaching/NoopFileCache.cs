﻿using System.Threading.Tasks;

namespace GroupDocs.Comparison.UI.Core.FileCaching
{
    public class NoopFileCache : IFileCache
    {
        public TEntry TryGetValue<TEntry>(string cacheKey, string filePath) =>
            default(TEntry);

        public Task<TEntry> TryGetValueAsync<TEntry>(string cacheKey, string filePath) =>
            Task.FromResult(default(TEntry));

        public void Set<TEntry>(string cacheKey, string filePath, TEntry entry) { }

        public Task SetAsync<TEntry>(string cacheKey, string filePath, TEntry entry) =>
            Task.CompletedTask;
    }
}