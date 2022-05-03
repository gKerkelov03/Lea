using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Lea.Web.Controllers;

[ApiController]
public abstract class ApiController : ControllerBase
{    
    protected IMediator Mediator => this.HttpContext.RequestServices.GetService<IMediator>();
}
