using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;


namespace WebAppUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuario _service;

        public TipoUsuarioController(ITipoUsuario service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<TipoUsuario> Get()
        {
            
            return _service.ConsultaTodos();
        }
    }
}