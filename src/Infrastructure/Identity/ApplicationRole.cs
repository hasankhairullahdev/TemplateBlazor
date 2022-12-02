using Microsoft.AspNetCore.Identity;
using TemplateBlazor.WebUI.Shared.Authorization;

namespace TemplateBlazor.Infrastructure.Identity;

public class ApplicationRole : IdentityRole
{
    public Permissions Permissions { get; set; }
}
