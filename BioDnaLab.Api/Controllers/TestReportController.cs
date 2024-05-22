using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using BioDnaLab.Application.CommandQuery.TestReport.Command.Create;
using BioDnaLab.Application.CommandQuery.TestReport.Command.Delete;
using BioDnaLab.Application.CommandQuery.TestReport.Command.Update;
using BioDnaLab.Application.CommandQuery.TestReport.Query.Get;
using BioDnaLab.Application.CommandQuery.TestReport.Query.GetById;
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
    public class TestReportController : ApiBaseController
    {
        public TestReportController(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {

        }

        [HttpGet("GetAllTestReport")]
        public async Task<IActionResult> GetAllTestReport()
        {
            var accounts = await _mediator.Send(new GetTestReportQuery());
            return Ok(accounts);
        }

        [HttpGet("GetTestReportById/{id}")]
        public async Task<IActionResult> GetTestReportById(long id)
        {
            var account = await _mediator.Send(new GerTestReportByIdQuery { Id = id });
            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }

        [HttpPost("CreateTestReport")]
        public async Task<IActionResult> CreateTestReport(CreateTestReportCommand command)
        {
            var createdItemId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTestReportById), new { id = createdItemId }, createdItemId);
        }

        [HttpPut("UpdateTestReport/{id}")]
        public async Task<IActionResult> UpdateTestReport(long id, UpdateTestReportCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID mismatch");
            }
            command.Id = id;
            await _mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("DeleteTestReport/{id}")]
        public async Task<IActionResult> DeleteTestReport(long id, DeleteTestReportCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}