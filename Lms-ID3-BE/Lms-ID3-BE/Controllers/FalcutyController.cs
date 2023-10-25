using Microsoft.AspNetCore.Mvc;


namespace Lms_ID3_BE.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FalcutyController : ControllerBase
  {
    // GET: api/<FalcutyController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/<FalcutyController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<FalcutyController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<FalcutyController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<FalcutyController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
