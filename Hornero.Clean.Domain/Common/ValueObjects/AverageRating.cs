using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;

namespace Hornero.Clean.Domain.Common.ValueObjects
{
    public sealed class AverageRating : ValueObject
    {
        public double Value { get; private set; }
        public int NumRatings { get; private set; }

        private AverageRating(double value, int numRating)
        {
            Value = value;
            NumRatings = numRating;
        }

        public static AverageRating CreateNew(double rating = 0, int numRating = 0)
        {
            return new(rating, numRating);
        }

        public void AddNewRating(Rating rating)
        {
            Value = ((Value * NumRatings) + rating.Value) / ++NumRatings;
        }

        public void RemoceRating(Rating rating)
        {
            Value = ((Value * NumRatings) - rating.Value) / --NumRatings;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}