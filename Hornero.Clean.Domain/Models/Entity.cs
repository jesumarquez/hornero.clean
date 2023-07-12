using System;

namespace Hornero.Clean.Domain.Common.Models
{
    public abstract class Entity<Tid> : IEquatable<Entity<Tid>>
        where Tid : notnull
    {
        public Tid Id { get; protected set; }

        protected Entity(Tid id)
        {
            Id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is Entity<Tid> entity && Id.Equals(entity.Id);
        }

        public bool Equals(Entity<Tid>? other)
        {
            return Equals((object?)other);
        }

        public static bool operator ==(Entity<Tid> left, Entity<Tid> right)
        {
            return Equals(left, right);
        }
        
        public static bool operator !=(Entity<Tid> left, Entity<Tid> right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}