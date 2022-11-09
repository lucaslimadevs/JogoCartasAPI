using Domain.Entities;
using Domain.Infraestructure.Controller;
using Domain.Infraestructure.Notification;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JogoCartasAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoJogoController : BasicController
    {
        private readonly TipoJogoRepository _repository;

        public TipoJogoController(INotification notification, TipoJogoRepository repository) : base(notification) 
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoJogo>> GetAll()
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

        [HttpPost]
        public ActionResult<TipoJogo> Insert(TipoJogo tipoJogo)
        {
            if (IsModelValid())
            {
                _repository.Insert(tipoJogo);
            }

            return CustomizeResponse(tipoJogo, "Tipo de jogo salvo com sucesso!");
        }

        [HttpPut]
        public ActionResult<TipoJogo> Update(TipoJogo tipoJogo)
        {
            if (IsModelValid())
            {
                _repository.Update(tipoJogo);
            }

            return CustomizeResponse(tipoJogo, "Tipo de jogo salvo com sucesso!");
        }

        [HttpDelete]
        public ActionResult<TipoJogo> Delete(TipoJogo tipoJogo)
        {
            _repository.Delete(tipoJogo);
            return CustomizeResponse(tipoJogo, "Tipo de jogo excluído com sucesso!");
        }
    }
}
