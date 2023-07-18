using System;
using Hornero.Clean.Domain.CastingAggregate.ValueObjects;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.CastingAggregate
{
    public sealed class Casting : AggregateRoot<CastingId>
    {
        private Casting(
            CastingId id,
            long castingNumber,
            DateTime startDateTime) : base(id)
        {
            Id = id;
            CastingNumber = castingNumber;
            StartDateTime = startDateTime;
        }

        public long CastingNumber { get; }
        public DateTime StartDateTime { get; }

        public static Casting Create(
            long castingNumber,
            DateTime startDateTime) => new(
                id: CastingId.Create(),
                castingNumber: castingNumber,
                startDateTime: startDateTime
            );
    }
}