using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
public abstract class ApiController : ControllerBase
{
    protected IMediator Mediator => HttpContext.RequestServices.GetService<IMediator>();
}
