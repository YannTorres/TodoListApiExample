using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseShortTaskJson Executar(int id)
    {
        return new ResponseShortTaskJson
        {
            Id = id,
            Name = "Exemplo de Nome da Task",
            Description = "Exemplo de Descrição"
        };
    }
}
