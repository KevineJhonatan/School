namespace School.Core.Interfaces.Services
{
    public interface IJwtTokenService
    {
        string GenerateToken(int userId, string userRole);
    }
}
