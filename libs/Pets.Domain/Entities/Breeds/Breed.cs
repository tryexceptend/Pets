using Pets.Domain.Entities.Animals;
using Pets.Domain.Entities.Pets;

namespace Pets.Domain.Entities.Breeds;
public class Breed : IEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public Animal? Animal { get; set; }
    public List<Pet> Pets { get; set; } = new();
}
