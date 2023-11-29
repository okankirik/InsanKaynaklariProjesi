using InsanKaynaklariProjesi.Domain.Entities;
using InsanKaynaklariProjesi.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Persistence.Context;

public class EmployeeContext :DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=OKAN\\SQLEXPRESS; initial Catalog=EmployeeDatabase; integrated Security=true;TrustServerCertificate=True;");
    }

    public DbSet<Employee> Employees { get; set; }

}
