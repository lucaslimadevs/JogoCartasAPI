﻿using Domain.Entities;
using Domain.Infraestructure.Notification;
using Domain.Infraestructure.Repository;
using System.Data;

namespace Domain.Repository
{
    public class CartaRepository : Repository<Carta>
    {
        public CartaRepository(IDbConnection connection, INotification notification) : base(connection, notification)
        {
        }
    }
}
