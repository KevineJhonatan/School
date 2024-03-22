using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Core.Enums;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.Admin;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using System.Security.Claims;

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

        [HttpPost("CreateSchoolYear")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = nameof(UserRole.Admin))]
        public IActionResult CreateSchoolYear([FromBody] CreateSchoolYearReq request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                _AdminService.CreateSchoolYear(request, userId);
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

        [HttpPost("CreateClass")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = nameof(UserRole.Admin))]
        public IActionResult CreateClass([FromBody] CreateClassReq request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                _AdminService.CreateClass(request, userId);
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
