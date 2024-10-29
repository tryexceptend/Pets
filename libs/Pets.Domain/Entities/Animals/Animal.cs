using Pets.Domain.Entities.Breeds;

namespace Pets.Domain.Entities.Animals;
public class Animal : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<Breed> Breeds { get; set; } = new();
}
