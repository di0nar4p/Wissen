using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;

namespace WebAppUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiaController : ControllerBase
    {
        private INoticiaService _service;

        public NoticiaController(INoticiaService service)
        {
            this._service = service;

        }

        [HttpGet]
        public IEnumerable<Noticia> Get()
        {
            return this._service.ConsultaTodos();
        }

    }
}