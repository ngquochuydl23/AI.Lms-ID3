using AutoMapper;
using Lms_ID3_BE.Dtos;
using Lms_ID3_BE.Infrastructure.Entities.Student;
using Lms_ID3_BE.Infrastructure.Exceptions;
using Lms_ID3_BE.Infrastructure.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Lms_ID3_BE.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StudentController : ControllerBase
  {
    private readonly IMapper _mapper;
    private readonly IRepository<StudentEntity> _studentRepo;

    public StudentController(IRepository<StudentEntity> studentRepo, IMapper mapper)
    {
      _studentRepo = studentRepo;
      _mapper = mapper;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    [HttpGet("{studentId}")]
    public IActionResult Get(string studentId)
    {
      var student = _studentRepo
        .GetQueryable()
        .FirstOrDefault(x => x.Id == studentId)
          ?? throw new AppException("Student not found");

      return Ok(_mapper.Map<StudentDto>(student));
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {

    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
