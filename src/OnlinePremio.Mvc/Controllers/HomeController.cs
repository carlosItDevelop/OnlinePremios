using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlinePremios.Mvc.ViewModels;
using OnlinePremios.Repositories.Interfaces;

namespace OnlinePremios.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILogger<HomeController> logger, ILancheRepository lancheRepository)
        {
            _logger = logger;
            _lancheRepository = lancheRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Errors(int id)
        {
            var modelErro = new ErrorViewModel();

            if (id == 500)
            {
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                modelErro.Titulo = "Ocorreu um erro!";
                modelErro.ErroCode = id;
            }
            else if (id == 404)
            {
                modelErro.Mensagem = "A página que está procurando não existe! <br />Em caso de dúvidas entre em contato com nosso suporte";
                modelErro.Titulo = "Ops! Página não encontrada.";
                modelErro.ErroCode = id;
            }
            else if (id == 403)
            {
                modelErro.Mensagem = "Você não tem permissão para fazer isto.";
                modelErro.Titulo = "Acesso Negado";
                modelErro.ErroCode = id;
            }
            else
            {
                return StatusCode(500);
            }

            return View("Error", modelErro);
        }


    }
}
