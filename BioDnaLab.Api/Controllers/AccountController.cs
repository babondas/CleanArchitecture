using BioDnaLab.Api.Helper.Token;
using BioDnaLab.Application.CommandQuery.Account.Command.Create;
using BioDnaLab.Application.CommandQuery.Account.Command.Delete;
using BioDnaLab.Application.CommandQuery.Account.Command.Update;
using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using BioDnaLab.Application.CommandQuery.Account.Query.Get;
using BioDnaLab.Application.CommandQuery.Account.Query.GetByEmailAndPassword;
using BioDnaLab.Application.CommandQuery.Account.Query.GetById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BioDnaLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ApiBaseController
    {
        GenerateToken _generateToken;
        public AccountController(IHttpContextAccessor httpContextAccessor, GenerateToken generateToken) : base(httpContextAccessor)
        {
            _generateToken = generateToken;
        }

        [HttpGet("GetAllAccounts")]
        public async Task<IActionResult> GetAllAccounts()
        {

            var accounts = await _mediator.Send(new GetAccountQuery());
            return Ok(accounts);
        }

        [HttpGet("GetAccountById/{id}")]
        public async Task<IActionResult> GetAccountById(long id)
        {
            var account = await _mediator.Send(new GetAccountByIdQuery { AccountId = id });
            if (account == null)
            {
                return NotFound();
            }
            
            return Ok(account);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<AccountDto>> Login([FromBody] GetAccountByEmailAndPasswordQuery query)
        {
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound("Account not found");
            }
            else
            {
                var token = _generateToken.GenerateJSONWebToken(result);
                return Ok(new { Token = token, Account = result });
            }
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAccount(CreateAccountCommand command)
        {
            var createdItem = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAccountById), new { id = createdItem.Id }, createdItem);
        }

        [HttpPut("UpdateAccount/{id}")]
        public async Task<IActionResult> UpdateAccount(long id, UpdateAccountCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("DeleteAccount/{id}")]
        public async Task<IActionResult> DeleteAccount(long id)
        {
            var result = await _mediator.Send(new DeleteAccountCommand { Id = id });
            if (result == 0)
                return BadRequest();
            return NoContent();
        }
    }
}
