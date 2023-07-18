using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.CastingAggregate.ValueObjects
{
    public sealed class CastingId : ValueObject
    {
        public long Value { get; }

        private CastingId(long value)
        {
            Value = value;
        }

        public static CastingId Create() => new CastingId(0);

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}