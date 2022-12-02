using TemplateBlazor.Domain.Common;

namespace TemplateBlazor.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string Title { get; set; } = string.Empty;

    public string Colour { get; set; } = string.Empty;

    public ICollection<TodoItem> Items { get; set; }
        = new List<TodoItem>();
}
