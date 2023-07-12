using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.DinnerAggregate.ValueObjects
{
    public sealed class DinnerId : ValueObject
    {
        public Guid Value { get; }

        private DinnerId(Guid value)
        {
            Value = value;
        }

        public static DinnerId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}