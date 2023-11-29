using InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;
using InsanKaynaklariProjesi.Application.Interfaces;
using InsanKaynaklariProjesi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;

public class CreateEmployeeCommandHandler
{
    private readonly IRepository<Employee> _repository;

    public CreateEmployeeCommandHandler(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateEmployeeCommand command)
    {
        await _repository.CreateAsync(new Employee
        {
            ProfilePicture = command.ProfilePicture,
            FirstName = command.FirstName,
            SecondName = command.SecondName,
            LastName = command.LastName,
            LastSecondName = command.LastSecondName,
            BirthDate = command.BirthDate,
            PlaceOfBirth = command.PlaceOfBirth,
            IdentityNumber = command.IdentityNumber,
            HireDate = command.HireDate,
            DismissalDate = command.DismissalDate,
            Profession = command.Profession,
            Email = command.Email,
            PhoneNumber = command.PhoneNumber,
            Salary = command.Salary
        });
    }
}
