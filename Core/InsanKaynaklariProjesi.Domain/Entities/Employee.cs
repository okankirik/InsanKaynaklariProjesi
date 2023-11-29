using InsanKaynaklariProjesi.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Domain.Entities;

public class Employee : BaseEntity
{
    public int Id { get; set; } // ıd
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
