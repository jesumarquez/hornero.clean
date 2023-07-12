using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.HostAgregate.ValueObjects
{
    public sealed class HostId : ValueObject
    {
        public Guid Value { get; }

        private HostId(Guid value)
        {
            Value = value;
        }

        public static HostId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}