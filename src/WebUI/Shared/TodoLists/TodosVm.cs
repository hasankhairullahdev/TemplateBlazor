using TemplateBlazor.WebUI.Shared.Common;

namespace TemplateBlazor.WebUI.Shared.TodoLists;

public class TodosVm
{
    public List<LookupDto> PriorityLevels { get; set; } = new();

    public List<TodoListDto> Lists { get; set; } = new();
}
