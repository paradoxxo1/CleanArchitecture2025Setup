namespace CleanArchitecture_2025.Domain.Abstractions;

public class Entity
{
    public Entity()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }

    #region Audit LOG

    public DateTimeOffset CreateAt { get; set; }
    public Guid CreateUserId { get; set; } = default!;
    public DateTimeOffset UpdateAt { get; set; }
    public Guid? UpdateUserId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset DeleteAt { get; set; }
    public Guid? DeleteUserId { get; set; }

    #endregion
}

