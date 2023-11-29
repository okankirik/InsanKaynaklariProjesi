using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Domain.Entities.Base;

public  class BaseEntity
{
    public byte[] ProfilePicture { get; set; } //Fotograf
    public string PhoneNumber { get; set; } //Telefon numarası
    public string Email { get; set; } //Mail adresi
    public string City { get; set; } //İl
    public string District { get; set; } //İlçe
    public string Neighbourhood { get; set; } //Mahalle
    public string Street { get; set; } //Cadde
    public string PostalCode { get; set; } //Posta kodu
}
