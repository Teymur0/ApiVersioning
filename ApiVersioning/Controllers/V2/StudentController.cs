using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers.V2;


[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[Controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    public List<Student> Students { get; set; } = new List<Student>
    {
        new Student(3, "Mahmood", 100),
        new Student(4, "Aslan", 100)
    };


   
    [MapToApiVersion("2.0")]
    [HttpGet("GetStudents")]
    public IActionResult GetStudents()
    {
        return Ok(Students);
    }

}
