using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;

namespace WebAppUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            this._service = service;

        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return this._service.ConsultaTodos();
        }

    }
}