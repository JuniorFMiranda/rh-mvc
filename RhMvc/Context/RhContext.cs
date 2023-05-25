using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RhMvc.Models;

namespace RhMvc.Context
{
    public class RhContext : DbContext
    {
        public RhContext(DbContextOptions<RhContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
