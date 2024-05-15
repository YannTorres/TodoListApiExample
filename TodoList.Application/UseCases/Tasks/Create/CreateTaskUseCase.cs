using TodoList.Communication.Requests;
using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.Tasks.Create;

public class CreateTaskUseCase
{
    public ResponseCreateNewTaskJson Executar(RequestTaskJson request)
    {
        return new ResponseCreateNewTaskJson
        {
            Id = 1,
            Description = request.Description,
            LimitDate = request.LimitDate,
            Name = request.Name,
            Priority = request.Priority,
            Status = request.Status,
        };
    }
}
