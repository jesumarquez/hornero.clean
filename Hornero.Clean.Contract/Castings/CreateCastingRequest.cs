using System;

namespace Hornero.Clean.Contract.Castings
{
    public record CreateCastingRequest(
        long CastingNumber,
        DateTime StartDateTime);
}