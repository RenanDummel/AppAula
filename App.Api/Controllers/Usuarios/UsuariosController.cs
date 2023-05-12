using App.Domain.DTO;
using App.Domain.Entidade;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        private IUsuariosService _service;

        public UsuariosController(IUsuariosService service)
        {
            _service = service;
        }

        [HttpGet("ListaUsuarios")]
        public JsonResult ListaUsuarios()
        {
            try
            {
                var obj = _service.ListaUsuarios();
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar([FromBody] Usuarios obj)
        {
            _service.Salvar(obj);
            return Json(RetornoApi.Sucesso(true));
        }
        [HttpDelete("Remover")]
        public JsonResult Remover(Guid Id)
        {
            try
            {
                _service.Remover(Id);
                return Json(RetornoApi.Sucesso(true));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
    }
}
