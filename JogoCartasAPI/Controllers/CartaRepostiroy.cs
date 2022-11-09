using Domain.Entities;
using Domain.Infraestructure.Notification;
using Domain.Infraestructure.Repository;
using System.Data;

namespace JogoCartasAPI.Controllers
{
    public class CartaRepostiroy : Repository<Carta>
    {
        public CartaRepostiroy(IDbConnection connection, INotification notification) : base(connection, notification)
        {
        }        
    }
}