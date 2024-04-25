using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentBusiness _employeeBusiness;
        public StudentController(IStudentBusiness StudentBusiness)
        {
            _employeeBusiness = StudentBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _employeeBusiness.GetList();

            if (!result.Any())
                return BadRequest();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromHeader] Guid id)
        {
            var result = await _employeeBusiness.GetById(id);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }
    }
}



