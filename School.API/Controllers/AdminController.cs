using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Core.Enums;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;

namespace School.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _AdminService;

        private readonly IJwtTokenService _JwtTokenService;

        public AdminController(IAdminService adminService, IJwtTokenService jwtTokenService)
        {
            _AdminService = adminService;
            _JwtTokenService = jwtTokenService;
        }

        [HttpPost("Login")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginReq request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var admin = _AdminService.Login(request);
                string accessToken = _JwtTokenService.GenerateToken(admin.Id, nameof(UserRole.Admin));
                response.Data = accessToken;
            }
            catch (ExceptionBase ex)
            {
                response.Success = false;
                response.Errors = ex.Errors;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Errors = ExceptionBase.FetchInnerException(ex);
            }
            return Ok(response);
        }
    }
}
