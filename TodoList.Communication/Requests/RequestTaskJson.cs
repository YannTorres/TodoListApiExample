using TodoList.Communication.Enums;

namespace TodoList.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityEnum Priority { get; set; }
    public DateTime LimitDate { get; set; }
    public StatusEnum Status { get; set; }
}
