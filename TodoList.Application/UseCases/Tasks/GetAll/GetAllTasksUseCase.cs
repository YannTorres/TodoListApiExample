using TodoList.Communication.Responses;

namespace TodoList.Application.UseCases.Tasks.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson()
        {
            Tasks = [
                new ResponseShortTaskJson()
                {
                    Id = 1,
                    Name = "Test 1",
                    Description = "Test 1",
                },
                new ResponseShortTaskJson()
                {
                    Id = 2,
                    Name = "Test 2",
                    Description = "Test 2",
                },
                new ResponseShortTaskJson()
                {
                    Id = 3,
                    Name = "Test 3",
                    Description = "Test 3",
                },
                new ResponseShortTaskJson()
                {
                    Id = 4,
                    Name = "Test 4",
                    Description = "Test 4",
                },
            ]
        };
    }
}
