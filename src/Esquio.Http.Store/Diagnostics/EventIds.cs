﻿using Microsoft.Extensions.Logging;

namespace Esquio.Http.Store.Diagnostics
{
    internal static class EventIds
    {
        public static EventId FindFeature = new EventId(800, nameof(FindFeature));
        public static EventId FeatureNotExist = new EventId(801, nameof(FeatureNotExist));
        public static EventId FindFeatureFromCache = new EventId(802, nameof(FindFeatureFromCache));
        public static EventId FindFeatureFromStore = new EventId(803, nameof(FindFeatureFromStore));
        public static EventId FeatureExistOnCache = new EventId(804, nameof(FeatureExistOnCache));
        public static EventId FeatureDoesNotExistOnCache = new EventId(805, nameof(FeatureDoesNotExistOnCache));

        public static EventId StoreRequestFailed = new EventId(810, nameof(StoreRequestFailed));
        public static EventId DistributedCacheIsNotRegistered = new EventId(811, nameof(DistributedCacheIsNotRegistered));
    }
}
