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
<<<<<<< HEAD
    {
=======
    {
        // GET api/values
>>>>>>> 5281fb4596a6962f57ce97322ca4f16915fe0f87
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
<<<<<<< HEAD
            if(value.Utterance == "hi")
            {
                return Ok("Hello!");
=======
            if(value.Utterance == "hi")
            {
                return Ok("{\"prediction\":{ \"topIntent\": \"Ярік бляяя бачок потік\"}}");
>>>>>>> 5281fb4596a6962f57ce97322ca4f16915fe0f87
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
