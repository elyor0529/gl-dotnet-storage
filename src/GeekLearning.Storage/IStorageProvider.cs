﻿namespace GeekLearning.Storage
{
    public interface IStorageProvider
    {
        string Name { get; }

        IStore BuildStore(string storeName, StorageOptions.StorageStore storeOptions);
    }
}
