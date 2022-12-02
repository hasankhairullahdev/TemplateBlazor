using TemplateBlazor.WebUI.Shared.TodoLists;

namespace TemplateBlazor.Application.TodoLists;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<TodoList, TodoListDto>();
        CreateMap<TodoItem, TodoItemDto>();
    }
}
