using Domain.Entities;
using Domain.Infraestructure.Notification;
using Domain.Infraestructure.Repository;
using System.Data;

namespace Domain.Repository
{
    public class JogoRepository : Repository<Jogo>
    {
        public JogoRepository(IDbConnection connection, INotification notification) : base(connection, notification)
        {
        }
    }
}
