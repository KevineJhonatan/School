using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Core.Enums;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;
using System.Security.Claims;

namespace School.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISuperAdminService _SuperAdminService;

        private readonly IJwtTokenService _JwtTokenService;

        public SuperAdminController(ISuperAdminService superAdminService, IJwtTokenService jwtTokenService)
        {
            _SuperAdminService = superAdminService;
            _JwtTokenService = jwtTokenService;
        }

        [HttpPost("CreateSchool")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = nameof(UserRole.SuperAdmin))]
        public IActionResult CreateSchool([FromBody] CreateSchoolReq request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                _SuperAdminService.CreateSchool(request, userId);
            } catch (ExceptionBase ex)
            {
                response.Success = false;
                response.Errors = ex.Errors;
            } catch (Exception  ex)
            {
                response.Success = false;
                response.Errors = ExceptionBase.FetchInnerException(ex);
            }
            return Ok(response);
        }

        [HttpPost("CreateAdmin")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Authorize(Roles = nameof(UserRole.SuperAdmin))]
        public IActionResult CreateAdmin([FromBody] CreateAdminReq request)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
                _SuperAdminService.CreateAdmin(request, userId);
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
                var admin = _SuperAdminService.Login(request);
                string accessToken = _JwtTokenService.GenerateToken(admin.Id, nameof(UserRole.SuperAdmin));
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

        [HttpGet("GeneratePassword")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //TODO [Authorize(Roles = nameof(UserRole.SuperAdmin))]
        public IActionResult GeneratePassword()
        {
            ApiResponse response = new ApiResponse();
            try
            {
                var pass = _SuperAdminService.GeneratePassword();
                response.Data = pass;
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