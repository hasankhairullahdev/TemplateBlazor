using TemplateBlazor.Application.Common.Services.Identity;
using TemplateBlazor.WebUI.Shared.AccessControl;

namespace TemplateBlazor.Application.Roles.Commands;

public record UpdateRoleCommand(RoleDto Role) : IRequest;

public class UpdateRoleCommandHandler : AsyncRequestHandler<UpdateRoleCommand>
{
    private readonly IIdentityService _identityService;

    public UpdateRoleCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    protected override async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        await _identityService.UpdateRoleAsync(request.Role);
    }
}
