using Cadastro_de_Contatos.Context;
using Cadastro_de_Contatos.Data;
using Cadastro_de_Contatos.Models;

namespace Cadastro_de_Contatos.Repositorio
{
    public class EquipamentoRepositorio : IEquipamentoRepositorio
    {
        private readonly AppDbContext _bancoContext;
        public EquipamentoRepositorio(AppDbContext appdbcontext)
        {
            _bancoContext = appdbcontext;
        }
        public ContatoModel Adicionar(ContatoModel equipamento)
        {
            _bancoContext.Equipamentos.Add(equipamento);
            _bancoContext.SaveChanges();
            return equipamento;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Equipamentos.ToList();
        }
    }
}
