using System;

namespace Hornero.Clean.Contract.Castings
{
    public record CastingResponse(
        long Id,
        long CastingNumber,
        DateTime StartDateTime
    );
}