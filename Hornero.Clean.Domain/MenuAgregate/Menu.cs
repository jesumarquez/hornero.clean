using System;
using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;
using Hornero.Clean.Domain.Common.ValueObjects;
using Hornero.Clean.Domain.DinnerAggregate.ValueObjects;
using Hornero.Clean.Domain.HostAgregate.ValueObjects;
using Hornero.Clean.Domain.MenuAgregate.Entities;
using Hornero.Clean.Domain.MenuAgregate.ValueObjects;
using Hornero.Clean.Domain.MenuReviewAgregate.ValueObjects;

namespace Hornero.Clean.Domain.MenuAgregate
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
        private readonly List<MenuSection> _sections = new();
        private readonly List<DinnerId> _dinnerIds = new();
        private readonly List<MenuReviewId> _menuReviewIds = new();

        public string Name { get; }
        public string Description { get; }
        public AverageRating AverageRating { get; }
        public HostId HostId { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }
        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyList<DinnerId> DinnersIds => _dinnerIds.AsReadOnly();
        public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();

        private Menu(
            MenuId id,
            string name,
            string description,
            HostId hostId,
            DateTime createdDateTime,
            DateTime updatedDateTime,
            AverageRating averageRating) : base(id)
        {
            Name = name;
            Description = description;
            HostId = hostId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
            AverageRating = averageRating;
        }

        private static Menu Create(
            string name, 
            string description,
            HostId hostId,
            DateTime createdDateTime,
            DateTime updatedDateTime,
            AverageRating averageRating)
        {
            return new(
                MenuId.CreateUnique(),
                name,
                description,
                hostId,
                createdDateTime,
                updatedDateTime,
                averageRating
            );
        }
    }
}