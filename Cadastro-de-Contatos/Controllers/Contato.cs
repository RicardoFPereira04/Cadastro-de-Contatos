using Cadastro_de_Contatos.Models;
using Cadastro_de_Contatos.Repositorio;
using Microsoft.AspNetCore.Mvc;


namespace Cadastro_de_Contatos.Controllers
{
    public class Contato : Controller
    {
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public Contato(IEquipamentoRepositorio equipamentoRepositorio)
        {
            _equipamentoRepositorio = equipamentoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _equipamentoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(ContatoModel equipamento)
        {
            _equipamentoRepositorio.Adicionar(equipamento);
            return RedirectToAction("Index");
        }
    }
}

