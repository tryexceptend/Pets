using Pets.Domain.Entities.Breeds;
using Pets.Domain.Entities.Users;

namespace Pets.Domain.Entities.Pets;
public class Pet : IEntity
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public int? BreedId { get; set; }
    public Breed? Breed { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
}
