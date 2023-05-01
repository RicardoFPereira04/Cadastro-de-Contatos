using Cadastro_de_Contatos.Models;
using Microsoft.EntityFrameworkCore;


namespace Cadastro_de_Contatos.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Equipamentos { get; set; }

    }
}