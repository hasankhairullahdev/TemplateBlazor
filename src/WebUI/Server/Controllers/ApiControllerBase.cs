using MediatR;
using Microsoft.AspNetCore.Mvc;
using TemplateBlazor.WebUI.Server.Filters;

namespace TemplateBlazor.WebUI.Server.Controllers;

[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender _mediator = null!;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
