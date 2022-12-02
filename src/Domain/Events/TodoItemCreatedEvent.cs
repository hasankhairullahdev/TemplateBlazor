using TemplateBlazor.Domain.Common;
using TemplateBlazor.Domain.Entities;

namespace TemplateBlazor.Domain.Events;

public class TodoItemCreatedEvent : BaseEvent
{
    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
