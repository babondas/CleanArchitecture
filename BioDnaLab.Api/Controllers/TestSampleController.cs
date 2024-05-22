using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestSample.Command.Create;
using BioDnaLab.Application.CommandQuery.TestSample.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestSample.Command.Update;
using BioDnaLab.Application.CommandQuery.TestSample.Query.Get;
using BioDnaLab.Application.CommandQuery.TestSample.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Application.CommandQuery.TestVolume.Query.Get;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BioDnaLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSampleController : ApiBaseController
    {
        public TestSampleController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpGet("GetAllTestSample")]
        public async Task<IActionResult> GetAllTestSample()
        {
            var accounts = await _mediator.Send(new GetTestSampleQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestSampleById/{id}")]
        public async Task<IActionResult> GetTestSampleById(long id)
        {
            var account = await _mediator.Send(new GetTestSampleByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestSample")]
        public async Task<IActionResult> CreateTestSample(CreateTestSampleCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestSampleById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestSample/{id}")]
        public async Task<IActionResult> UpdateTestSample(long id, UpdateTestSampleCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestSample/{id}")]
        public async Task<IActionResult> DeleteTestSample(long id, DeleeTestSampleCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}