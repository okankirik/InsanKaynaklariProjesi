using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariProjesi.Application.Features.Commands.EmployeeCommands;

public class RemoveEmployeeCommand
{
    public RemoveEmployeeCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
