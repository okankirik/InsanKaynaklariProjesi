using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Queries.EmployeeQueries;

public class GetEmployeeByIdQuery
{
    public GetEmployeeByIdQuery(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
