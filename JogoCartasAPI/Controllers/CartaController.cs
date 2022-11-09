using Domain.Entities;
using Domain.Infraestructure.Controller;
using Domain.Infraestructure.Notification;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JogoCartasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CartaController : BasicController
    {
        private readonly CartaRepostiroy _repository;

        public CartaController(INotification notification, CartaRepostiroy repository) : base(notification)
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Carta>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<TipoJogo> Get(int id)
        {
            var tipoJogo = _repository.Get(id);
            if (tipoJogo != null)
                return Ok(tipoJogo);
            return NotFound();
        }

    }
}
