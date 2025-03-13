using CleanArchitecture_2025.Domain.Users;

namespace CleanArchitecture_2025.Application.Services;

public interface IJwtProvider
{
    public Task<string> CreateTokenAsync(AppUser user, CancellationToken cancellationToken = default);
}
