using InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;
using InsanKaynaklariProjesi.Application.Interfaces;
using InsanKaynaklariProjesi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;

public class UpdateEmployeeHandler
{
    private readonly IRepository<Employee> _repository;

    public UpdateEmployeeHandler(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateEmployeeCommand command)
    {
        var values = await _repository.GetByIdAsync(command.Id);
        values.FirstName = command.FirstName;
        values.SecondName = command.SecondName;
        values.LastName = command.LastName;
        values.LastSecondName = command.LastSecondName;
        values.BirthDate = command.BirthDate;
        values.PlaceOfBirth = command.PlaceOfBirth;
        values.IdentityNumber = command.IdentityNumber;
        values.HireDate = command.HireDate;
        values.DismissalDate = command.DismissalDate;
        values.IsActive = command.IsActive;
        values.Profession = command.Profession;
        values.Email = command.Email;
        values.PhoneNumber = command.PhoneNumber;
        values.Salary = command.Salary;
        await _repository.UpdateAsync(values);

    }
}
