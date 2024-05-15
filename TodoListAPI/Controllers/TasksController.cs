using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TodoList.Application.UseCases.Tasks.Create;
using TodoList.Application.UseCases.Tasks.Delete;
using TodoList.Application.UseCases.Tasks.Edit;
using TodoList.Application.UseCases.Tasks.GetAll;
using TodoList.Application.UseCases.Tasks.GetById;
using TodoList.Communication.Requests;
using TodoList.Communication.Responses;

namespace TodoList.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateNewTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult CreateNewTask([FromBody] RequestTaskJson request)
    {
        var response = new CreateTaskUseCase().Executar(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult EditTask(int id, [FromBody] RequestTaskJson request)
    {
        var useCase = new EditTaskUseCase();

        useCase.Executar(id, request);

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseShortTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById([FromRoute] int id)
    {
        var response = new GetTaskByIdUseCase().Executar(id);

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult GetAllTasks()
    {
        var response = new GetAllTasksUseCase().Execute();

        if (response.Tasks.Count < 1)
        {
            return NoContent();
        }

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
    public IActionResult DeleteTaskById(int id) 
    {
        var useCase = new DeleteTaskByIdUseCase();
        useCase.Executar(id);

        return NoContent();
    }

}
