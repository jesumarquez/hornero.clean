using System;
using ErrorOr;
using Hornero.Clean.Domain.CastingAggregate;
using MediatR;

namespace Hornero.Clean.Application.Castings.Commands
{
    public record CreateCastingCommand(
        long CastingNumber,
        DateTime StartDateTime) : IRequest<ErrorOr<Casting>>;
}