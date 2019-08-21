using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Repositories;

namespace Senai.Peoples.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>()
        {
            new FuncionarioDomain { IdFuncionario = 1, Nome = "Catarina", Sobrenome = "Strada"}
           ,new FuncionarioDomain { IdFuncionario = 2, Nome = "Tadeu", Sobrenome = "Vitelli"}
        };

        FuncionarioRepository FuncionarioRepository = new FuncionarioRepository();

        [HttpGet]
        public IEnumerable<FuncionarioDomain> Listar()
        {
            return FuncionarioRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            FuncionarioDomain Funcionario = FuncionarioRepository.BuscarPorId(id);
            if (Funcionario == null)
            {
                return NotFound();
            }
            return Ok(Funcionario);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            FuncionarioRepository.Deletar(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(FuncionarioDomain funcionarioDomain)
        {
            FuncionarioRepository.Alterar(funcionarioDomain);
            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar(FuncionarioDomain funcionarioDomain)
        {
            FuncionarioRepository.Cadastrar(funcionarioDomain);
            return Ok();
        }
    }
}