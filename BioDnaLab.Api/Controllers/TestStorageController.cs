using BioDnaLab.Application.CommandQuery.TestStorage.Command.Create;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestStorage.Command.Update;
using BioDnaLab.Application.CommandQuery.TestStorage.Query.Get;
using BioDnaLab.Application.CommandQuery.TestStorage.Query.GetById;
using Microsoft.AspNetCore.Mvc;

namespace BioDnaLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestStorageController : ApiBaseController
    {
        public TestStorageController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpGet("GetAllTestStorage")]
        public async Task<IActionResult> GetAllTestStorage()
        {
            var accounts = await _mediator.Send(new GetTestStorageQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestStorageById/{id}")]
        public async Task<IActionResult> GetTestStorageById(long id)
        {
            var account = await _mediator.Send(new GetTestStorageByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestStorage")]
        public async Task<IActionResult> CreateTestStorage(CreateTestStorageCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestStorageById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestStorage/{id}")]
        public async Task<IActionResult> UpdateTestStorage(long id, UpdateTestStorageCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestStorage/{id}")]
        public async Task<IActionResult> DeleteTestStorage(long id, DeleteTestStorageCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}