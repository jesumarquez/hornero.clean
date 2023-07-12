using System.Collections.Generic;
using Hornero.Clean.Domain.Common.Models;
using Hornero.Clean.Domain.MenuAgregate.ValueObjects;

namespace Hornero.Clean.Domain.MenuAgregate.Entities
{
    public sealed class MenuSection : Entity<MenuSectionId>
    {
        private readonly List<MenuItem> _items = new();
        public string Name { get; }
        public string Description { get; }
        public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

        private MenuSection(
            MenuSectionId id,
            string name,
            string description,
            List<MenuItem> items) : base(id)
        {
            Name = name;
            Description = description;
            _items = items;
        }

        public static MenuSection Create(
            string name,
            string description,
            List<MenuItem> items)
        {
            return new(
                MenuSectionId.CreateUnique(),
                name,
                description,
                items ?? new());
        }
    }
}