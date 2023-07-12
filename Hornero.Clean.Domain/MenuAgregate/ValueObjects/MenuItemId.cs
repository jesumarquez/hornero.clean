using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.MenuAgregate.ValueObjects
{
    public sealed class MenuItemId : ValueObject
    {
        public Guid Value { get; }

        private MenuItemId(Guid value)
        {
            Value = value;
        }

        public static MenuItemId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}