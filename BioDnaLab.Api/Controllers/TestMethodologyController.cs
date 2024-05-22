using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Create;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestMethodology.Command.Update;
using BioDnaLab.Application.CommandQuery.TestMethodology.Query.Get;
using BioDnaLab.Application.CommandQuery.TestMethodology.Query.GetById;
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
    public class TestMethodologyController : ApiBaseController
    {
        public TestMethodologyController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpGet("GetAllTestMethodology")]
        public async Task<IActionResult> GetAllTestMethodology()
        {
            var accounts = await _mediator.Send(new GetTestMetholodogyQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestMethodologyById/{id}")]
        public async Task<IActionResult> GetTestMethodologyById(long id)
        {
            var account = await _mediator.Send(new GetTestMetholodogyByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestMethodology")]
        public async Task<IActionResult> CreateTestMethodology(CreateTestMetholodogyCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestMethodologyById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestMethodology/{id}")]
        public async Task<IActionResult> UpdateTestMethodology(long id, UpdateTestMetholodogyCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestMethodology/{id}")]
        public async Task<IActionResult> DeleteTestMethodology(long id, DeleteTestMetholodogyCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}