using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Interfaces;

public interface IRepository<T> where T : class
{
    //Bütün entitylerimizin kullacağı 5 temel uygulama metodu 

    Task<List<T>> GetAllAsync();
    //Idyegöre getirme işlemi için
    Task<T> GetByIdAsync(int id);
    //Listeleme işlemi için
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
}
