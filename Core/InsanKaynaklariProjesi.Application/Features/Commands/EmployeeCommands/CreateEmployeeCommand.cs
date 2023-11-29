using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;

public class CreateEmployeeCommand
{
    public byte[] ProfilePicture { get; set; } //Fotograf
    public string PhoneNumber { get; set; } //Telefon numarası
    public string Email { get; set; } //Mail adresi
    public string City { get; set; } //İl
    public string District { get; set; } //İlçe
    public string Neighbourhood { get; set; } //Mahalle
    public string Street { get; set; } //Cadde
    public string PostalCode { get; set; } //Posta kodu
    public string FirstName { get; set; } // İsim
    public string SecondName { get; set; } // İkinci İsim
    public string LastName { get; set; } // Soyadı
    public string LastSecondName { get; set; } // İkincil Soyadı
    public DateTime BirthDate { get; set; } // Doğum tarihi
    public string PlaceOfBirth { get; set; } //Doğum yeri
    public string IdentityNumber { get; set; } // TC 
    public DateTime HireDate { get; set; } //İşe alma tarihi
    public DateTime? DismissalDate { get; set; } // İşten ayrılma tarihi
    public bool IsActive { get; set; } //İş aktiflik durumu
    public string Profession { get; set; } //Meslek
    public string Department { get; set; } //Departman

    public decimal Salary { get; set; } // Maaş
}
