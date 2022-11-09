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
    public class JogoController : BasicController
    {
        private readonly JogoRepository _repository;

        public JogoController(INotification notification, JogoRepository repository) : base(notification)
        {
            this._repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Jogo>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Jogo> Get(int id)
        {
            var jogo = _repository.Get(id);
            if (jogo != null)
                return Ok(jogo);
            return NotFound();
        }

        [HttpPost]
        public ActionResult<Jogo> Insert(Jogo jogo)
        {
            if (IsModelValid())
            {
                _repository.Insert(jogo);
            }

            return CustomizeResponse(jogo, "Jogo salvo com sucesso!");
        }

        [HttpPut]
        public ActionResult<Jogo> Update(Jogo jogo)
        {
            if (IsModelValid())
            {
                _repository.Update(jogo);
            }

            return CustomizeResponse(jogo, "Jogo salvo com sucesso!");
        }

        [HttpDelete]
        public ActionResult<Jogo> Delete(Jogo jogo)
        {
            _repository.Delete(jogo);
            return CustomizeResponse(jogo, "Jogo excluído com sucesso!");
        }
    }
}
