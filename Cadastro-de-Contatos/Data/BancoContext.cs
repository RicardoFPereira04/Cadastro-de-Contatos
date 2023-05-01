using Cadastro_de_Contatos.Context;
using Cadastro_de_Contatos.Models;
using Microsoft.EntityFrameworkCore;


namespace Cadastro_de_Contatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Equipamento { get; set; }

        public static implicit operator BancoContext(AppDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}

