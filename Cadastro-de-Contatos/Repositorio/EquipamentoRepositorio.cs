using Cadastro_de_Contatos.Context;
using Cadastro_de_Contatos.Data;
using Cadastro_de_Contatos.Models;

namespace Cadastro_de_Contatos.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            _bancoContext = appdbcontext;
        }
        public ContatoModel Adicionar(ContatoModel equipamento)
        {
            _bancoContext.Equipamento.Add(equipamento);
            _bancoContext.SaveChanges();
            return equipamento;
        }
    }
}
