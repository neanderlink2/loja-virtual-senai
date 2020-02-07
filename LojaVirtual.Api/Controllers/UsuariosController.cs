using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LojaVirtual.Api.Controllers
{
    [Route("api/usuarios")]
    public class UsuariosController : Controller
    {
        private List<Usuario> _usuarios;

        public UsuariosController()
        {
            _usuarios = new List<Usuario>()
            {
                new Usuario("neander", "123")
            };
        }

        // GET: api/usuarios
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarios);
        }

        // GET api/usuarios/{id}
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var usuario = _usuarios.FirstOrDefault(usuario => usuario.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
