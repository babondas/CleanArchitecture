using BioDnaLab.Domain.IRepository.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BioDnaLab.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiBaseController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        
        protected ISender _mediator => mediator ??= _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<ISender>();

        private ISender mediator;

        protected ApiBaseController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            
        }
    }
}
