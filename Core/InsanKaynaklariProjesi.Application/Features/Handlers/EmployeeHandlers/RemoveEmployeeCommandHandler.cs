using InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;
using InsanKaynaklariProjesi.Application.Interfaces;
using InsanKaynaklariProjesi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;

public class RemoveEmployeeCommandHandler
{
    private readonly IRepository<Employee> _repository;

    public RemoveEmployeeCommandHandler(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveEmployeeCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.RemoveAsync(value);
    }
}
