using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestSchedule.Command.Create;
using BioDnaLab.Application.CommandQuery.TestSchedule.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestSchedule.Command.Update;
using BioDnaLab.Application.CommandQuery.TestSchedule.Query.Get;
using BioDnaLab.Application.CommandQuery.TestSchedule.Query.GetById;
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
    public class TestScheduleController : ApiBaseController
    {
        public TestScheduleController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpGet("GetAllTestSchedule")]
        public async Task<IActionResult> GetAllTestSchedule()
        {
            var accounts = await _mediator.Send(new GetTestScheduleQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestScheduleById/{id}")]
        public async Task<IActionResult> GetTestScheduleById(long id)
        {
            var account = await _mediator.Send(new GetTestScheduleByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestSchedule")]
        public async Task<IActionResult> CreateTestSchedule(CreateTestScheduleCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestScheduleById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestSchedule/{id}")]
        public async Task<IActionResult> UpdateTestSchedule(long id, UpdateTestScheduleCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestSchedule/{id}")]
        public async Task<IActionResult> DeleteTestSchedule(long id, DeleteTestScheduleCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}