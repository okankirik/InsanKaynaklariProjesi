using InsanKaynaklariProjesi.Application.Features.Queries.EmployeeQueries;
using InsanKaynaklariProjesi.Application.Features.Results.EmployeeResults;
using InsanKaynaklariProjesi.Application.Interfaces;
using InsanKaynaklariProjesi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;

public class GetEmployeeByIdQueryHandler
{
    private readonly IRepository<Employee> _repository;

    public GetEmployeeByIdQueryHandler(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetEmployeeByIdQueryResult
        {
            ProfilePicture = values.ProfilePicture,
            FirstName = values.FirstName,
            SecondName = values.SecondName,
            LastName = values.LastName,
            LastSecondName = values.LastSecondName,
            BirthDate = values.BirthDate,
            PlaceOfBirth = values.PlaceOfBirth,
            IdentityNumber = values.IdentityNumber,
            HireDate = values.HireDate,
            DismissalDate = values.DismissalDate,
            IsActive = values.IsActive,
            Profession = values.Profession,
            Department = values.Department,
            Email = values.Email,
            PhoneNumber = values.PhoneNumber,
        };
    }
}
