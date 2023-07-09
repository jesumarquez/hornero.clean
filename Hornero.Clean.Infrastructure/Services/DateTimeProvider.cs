using System;
using Hornero.Clean.Application.Common.Interfaces.Services;

namespace Hornero.Clean.Application.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}