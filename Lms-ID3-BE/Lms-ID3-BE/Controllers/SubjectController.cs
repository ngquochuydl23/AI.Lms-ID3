using Microsoft.AspNetCore.Mvc;


namespace Lms_ID3_BE.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SubjectController : ControllerBase
  {
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<SubjectController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<SubjectController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<SubjectController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<SubjectController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
