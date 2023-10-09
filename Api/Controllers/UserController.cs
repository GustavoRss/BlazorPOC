using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MinhaApiUsuarios.Controllers
{
    [Route("api-blazor/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<Usuario> usuarios = new List<Usuario>
{
            new Usuario{ Nome = "Gustavo", Email="gustavo@email.com", Tipo="Administrador" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return Ok(usuarios);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("Dados do usuário inválidos.");
            }

            usuarios.Add(usuario);

            return Ok("Usuário cadastrado com sucesso.");
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
    }
}