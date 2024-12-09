using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[Controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    public List<Student> Students { get; set; } = new List<Student>
    {
        new Student(1, "Abdulaziz", 100),
        new Student(2, "Rasul", 100),
    };

  

    [MapToApiVersion("1.0")]
    [HttpGet("GetStudents")]
    public IActionResult GetStudentsV1()
    {
        return Ok(Students);
    }


}
