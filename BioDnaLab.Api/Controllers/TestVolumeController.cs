using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Create;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestVolume.Command.Update;
using BioDnaLab.Application.CommandQuery.TestVolume.Query.Get;
using Microsoft.AspNetCore.Mvc;

namespace BioDnaLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestVolumeController : ApiBaseController
    {
        public TestVolumeController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            
        }
       
        [HttpGet("GetAllTestVolume")]
        public async Task<IActionResult> GetAllTestVolume()
        {
            var accounts = await _mediator.Send(new GetTestVolumeQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestVolumeById/{id}")]
        public async Task<IActionResult> GetTestVolumeById(long id)
        {
            var account = await _mediator.Send(new GetTestVolumeByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestVolume")]
        public async Task<IActionResult> CreateTestVolume(CreateTestVolumeCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestVolumeById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestVolume/{id}")]
        public async Task<IActionResult> UpdateTestVolume(long id, UpdateTestVolumeCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestVolume/{id}")]
        public async Task<IActionResult> DeleteTestVolume(long id, DeleteTestVolumeCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}
