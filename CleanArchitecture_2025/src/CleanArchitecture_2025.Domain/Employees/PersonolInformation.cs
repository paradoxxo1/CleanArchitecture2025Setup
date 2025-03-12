namespace CleanArchitecture_2025.Domain.Employees;

public sealed record PersonolInformation
{
    public string TCNo { get; set; } = default!;
    public string? Email { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
}

