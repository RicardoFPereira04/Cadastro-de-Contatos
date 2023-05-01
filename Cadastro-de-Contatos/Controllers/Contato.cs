using Cadastro_de_Contatos.Models;
using Cadastro_de_Contatos.Repositorio;
using Microsoft.AspNetCore.Mvc;


namespace Cadastro_de_Contatos.Controllers
{
    public class ControllerEquipamentos : Controller
    {
        private readonly IEquipamentoRepositorio _equipamentoRepositorio;
        public ControllerEquipamentos(IEquipamentoRepositorio equipamentoRepositorio)
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Adicionar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Apagar()
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

