using Domain.Infraestructure.Repository;
using System.Data;
using Domain.Infraestructure.Notification;
using Domain.Entities;

namespace Domain.Repository
{
    public class TipoJogoRepository : Repository<TipoJogo>
    {
        public TipoJogoRepository(IDbConnection connection, INotification notification) : base(connection, notification)
        {
        }
    }
}
