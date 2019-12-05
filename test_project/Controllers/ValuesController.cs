using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test_project.Models;
using test_project.Services;

namespace test_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Hello World";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChatBotParametrs value)
        {
            if(value.Utterance == "hi")
            {
                return Ok("{\"prediction\":{ \"topIntent\": \"Ярік бляяя бачок потік\"}}");
            }
            try
            {
                var result = await CallBotService.MakeRequest(value.Utterance);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
