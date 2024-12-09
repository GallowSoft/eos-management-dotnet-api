namespace GallowSoft.EosManagement.Core.Entities;

public class User : IAggregateRoot
{
    public int Id { get; set; }
    public Guid Uid { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string LegalName { get; set; }
    public required string DisplayName { get; set; }
    public DateOnly DateOfBirth { get; set; }

}