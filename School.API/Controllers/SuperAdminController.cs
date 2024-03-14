using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using School.Core.Exceptions;
using School.Core.Interfaces.Services;
using School.Core.JsonRequest.SuperAdmin;
using School.Core.JsonResponse;

namespace School.API.Controllers
{

    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISuperAdminService _SuperAdminService;

        public SuperAdminController(ISuperAdminService superAdminService)
        {
            _SuperAdminService = superAdminService;
        }

        [HttpPost("CreateSchool")]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateSchool([FromBody] CreateSchoolReq schoolReq)
        {
            ApiResponse response = new ApiResponse();
            try
            {
                _SuperAdminService.CreateSchool(schoolReq, 1);
            } catch (ExceptionBase ex)
            {
                response.Success = false;
                response.Errors = ex.Errors;
            }
            return Ok(response);
        }
    }
}
