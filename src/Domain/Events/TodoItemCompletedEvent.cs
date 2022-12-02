using TemplateBlazor.Domain.Common;
using TemplateBlazor.Domain.Entities;

namespace TemplateBlazor.Domain.Events;

public class TodoItemCompletedEvent : BaseEvent
{
    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }

    public TodoItem Item { get; }
}
