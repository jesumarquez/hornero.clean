using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.Common.ValueObjects
{
    public sealed class Rating : ValueObject
    {
        public int Value { get; }

        private Rating(int value)
        {
            Value = value;
        }

        public static Rating CreateUnique()
        {
            return new(0);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}