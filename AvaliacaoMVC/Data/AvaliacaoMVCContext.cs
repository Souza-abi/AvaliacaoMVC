using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvaliacaoMVC.Models;

namespace AvaliacaoMVC.Data
{
    public class AvaliacaoMVCContext : DbContext
    {
        public AvaliacaoMVCContext (DbContextOptions<AvaliacaoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AvaliacaoMVC.Models.Aluno> Aluno { get; set; } = default!;
    }
}
