﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using Shared.Dtos;
using Tracked.Models;

namespace Tracked.Contexts {
    public class StorageContext {
        public readonly IBlobCache Storage = BlobCache.LocalMachine;

        public IList<CreateRideDto> GetPendingRideUploads() {
            var attempts = Storage.GetAllObjects<CreateRideDto>().Wait();

            return attempts.ToList();
        }

        public async Task SaveObject<T>(Guid id, T obj) {
            await Storage.InsertObject(id.ToString(), obj);
        }

        public async Task RemoveObject<T>(Guid id) {
            await Storage.InvalidateObject<T>(id.ToString());
        }

        public async Task SetAccessToken(string token) {
            await BlobCache.Secure.InsertObject("AccessToken", token);
        }

        public string GetAccessToken() {
            return BlobCache.Secure.GetOrCreateObject("AccessToken", () => string.Empty).Wait();
        }

        public async Task SetName(string name) {
            await BlobCache.Secure.InsertObject("Name", name);
        }

        public string GetName() {
            return BlobCache.Secure.GetOrCreateObject("Name", () => string.Empty).Wait();
        }
    }
}
