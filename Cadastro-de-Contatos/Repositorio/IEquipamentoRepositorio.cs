

using Cadastro_de_Contatos.Models;

namespace Cadastro_de_Contatos.Repositorio
{
    public interface IEquipamentoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel equipamento);
    }
}
