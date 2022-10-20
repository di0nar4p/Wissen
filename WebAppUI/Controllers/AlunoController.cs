using Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;

namespace WebAppUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAluno _service;

        public AlunoController(IAluno service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _service.ConsultaTodos();
        }
    }
}