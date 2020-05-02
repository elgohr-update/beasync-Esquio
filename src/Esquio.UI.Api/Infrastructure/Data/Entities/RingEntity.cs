﻿using System;

namespace Esquio.UI.Api.Infrastructure.Data.Entities
{
    public sealed class RingEntity : IAuditable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool ByDefault { get; set; }

        public int ProductEntityId { get; set; }

        public ProductEntity ProductEntity { get; set; }

        public RingEntity(int productEntityId, string name, bool byDefault = false)
        {
            ProductEntityId = productEntityId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ByDefault = byDefault;
        }
    }
}
