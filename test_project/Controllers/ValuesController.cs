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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ChatBotParametrs value)
        {
            if(value.Utterance == "hi")
            {
                return Ok("Hello!");
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
