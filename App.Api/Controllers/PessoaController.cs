using App.Domain.DTO;
using App.Domain.Entidade;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private IPessoaService _service;
        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpGet("ListaPessoas")]
        public JsonResult ListaPessoas(string busca)
        {
            try
            {
                var obj = _service.ListaPessoas();
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpGet("BuscaPorId")]
        public JsonResult BuscaPorId(Guid id)
        {
            try
            {
                var obj = _service.BuscaPorId(id);
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar(string nome, int peso, DateTime dataNascimento, bool ativo)
        {
            var obj = new Pessoa
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Peso = peso,
                Ativo = ativo
            };
            _service.Salvar(obj);
            return Json(true);
        }
    }
}
