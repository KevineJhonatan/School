using Microsoft.IdentityModel.Tokens;
using School.Core;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonResponse;
using School.Core.Settings;
using School.Infrastructure.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School.Service
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly JwtSetting _JwtSettings;

        private readonly ISysParamValueRepository _SysParamRepo;

        public JwtTokenService(JwtSetting jwtSetting, ISysParamValueRepository sysParamRepo)
        {
            _JwtSettings = jwtSetting;
            _SysParamRepo = sysParamRepo;
        }
        public string GenerateToken(int userId, string userRole)
        {
            if (userId <= 0)
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_USERID_ERROR_CODE) });

            if (string.IsNullOrEmpty(userRole))
                throw new ExceptionBase(new List<Error> { _SysParamRepo.GetErrorByCode(Error.INVALID_USERROLE_ERROR_CODE) });

            userRole = userRole.Trim();

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Role, userRole)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Audience = _JwtSettings.Audiences.First(),
                Issuer = _JwtSettings.Issuer,
                NotBefore = DateTime.UtcNow,
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddHours(Constants.TOKEN_EXPIRATION_HOUR),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtSettings.SignInKey)), SecurityAlgorithms.HmacSha256)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(createdToken);
        }
    }
}
