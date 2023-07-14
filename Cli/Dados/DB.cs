using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli.Dados;

internal class DB: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Filename=D:\\Git\\FormDecode\\Cli\\roteiro.sqlite");
    }

    public DbSet<Roteiro> Roteiro { get; set; } = null!;
    public DbSet<Requisicao> Requisicao { get; set; } = null!;
}
