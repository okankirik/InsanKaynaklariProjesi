using InsanKaynaklariProjesi.Application.Features.Results.EmployeeResults;
using InsanKaynaklariProjesi.Application.Interfaces;
using InsanKaynaklariProjesi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Handlers.EmployeeHandlers;

public class GetEmployeeQueryHandler
{
    private readonly IRepository<Employee> _repository;

    public GetEmployeeQueryHandler(IRepository<Employee> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetEmployeeQueryResult>> Handle() //Handle CQRS kullanılırken gerçekleştirilen metot ismidir. 
    {
        //Bize sorunsuz olarak bütün verileri listeleyecek. 
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetEmployeeQueryResult
        { // Ctrl+space yaptığımızda gelen propertyler GetEmployeeQueryResult'ın içindeki propertyler GetEmployeeQueryResult'ın içindeki propertyler x'ten sonra gelen değerleri Employee sınıfının içindeki propertylerden alacağız.
            ProfilePicture = x.ProfilePicture,
            FirstName = x.FirstName,
            SecondName = x.SecondName,
            LastName = x.LastName,
            LastSecondName = x.LastSecondName,
            BirthDate = x.BirthDate,
            PlaceOfBirth = x.PlaceOfBirth,
            IdentityNumber = x.IdentityNumber,
            HireDate = x.HireDate,
            DismissalDate = x.DismissalDate,
            IsActive = x.IsActive,
            Profession = x.Profession,
            Department = x.Department,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber

        }).ToList();

    }

}
