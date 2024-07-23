using Microsoft.EntityFrameworkCore;
using PMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<Plant> Plants { get; }
        DbSet<Category> Categories { get; }
    }
}
