using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.MenuAgregate.ValueObjects
{
    public sealed class MenuId : ValueObject
    {
        public Guid Value { get; }

        private MenuId(Guid value)
        {
            Value = value;
        }

        public static MenuId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}