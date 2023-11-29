using InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;
using InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;
using Microsoft.AspNetCore.Mvc;

namespace InsanKaynaklariProjesi.MVC.Controllers;

public class EmployeeController : Controller
{
    private readonly CreateEmployeeCommandHandler _createEmployeeCommandHandler;
    private readonly GetEmployeeByIdQueryHandler _getEmployeeByIdQueryHandler;
    private readonly GetEmployeeQueryHandler _getEmployeeQueryHandler;
    private readonly RemoveEmployeeCommandHandler _removeEmployeeCommandHandler;
    private readonly UpdateEmployeeHandler _updateEmployeeCommandHandler;

    [HttpGet]
    public async Task<IActionResult> EmployeeList()
    {
        var values = await _getEmployeeQueryHandler.Handle();
        return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployee(int id)
    {
        var value = await _getEmployeeByIdQueryHandler.Handle(new Application.Features.Queries.EmployeeQueries.GetEmployeeByIdQuery(id));
        return Ok(value);
    }
    //Bu bir denemedir.
    
}
