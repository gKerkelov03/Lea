using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers;

[ApiController]
public abstract class ApiController : ControllerBase
{
    private IMediator mediator;

    protected IMediator Mediator => this.HttpContext.RequestServices.GetService<IMediator>();
}
