﻿using Microsoft.AspNetCore.Authorization;
using TemplateBlazor.WebUI.Shared.Authorization;
using System.Security.Claims;

namespace TemplateBlazor.WebUI.Shared.Authorization;

public static class IAuthorizationServiceExtensions
{
    public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, Permissions permissions)
    {
        return service.AuthorizeAsync(user, PolicyNameHelper.GeneratePolicyNameFor(permissions));
    }
}
