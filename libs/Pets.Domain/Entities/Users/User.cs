using Pets.Domain.Entities.Pets;

namespace Pets.Domain.Entities.Users;
public class User : IEntity
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public bool EmailChecked { get; set; }
    public DateTime DtCreated { get; set; }
    public string? Token { get; set; }
    public List<Pet> Pets { get; set; } = new();
}
